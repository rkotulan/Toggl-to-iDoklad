// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImportFacade.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Facades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IdokladSdk;
    using IdokladSdk.ApiFilters;
    using IdokladSdk.ApiModels;
    using IdokladSdk.ApiModels.BaseModels;
    using IdokladSdk.Enums;

    using Toggl;
    using Toggl.QueryObjects;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Enums;
    using TogglToInvoice.Common.Extensions;
    using TogglToInvoice.Common.Infrastructure.BackgroundFacade;
    using TogglToInvoice.Common.Services;

    public class ImportFacade : IImportFacade
    {
        private readonly AppSetings appSetings;

        private readonly IDokladApiService dokladApiService;

        private readonly ITimeFormaterService timeFormaterService;

        public ImportFacade(
            IDokladApiService dokladApiService,
            ITimeFormaterService timeFormaterService,
            IAppLogger appLogger,
            AppSetings appSetings)
        {
            this.dokladApiService = dokladApiService;
            this.timeFormaterService = timeFormaterService;
            this.appSetings = appSetings;
            this.AppLogger = appLogger;
        }

        public event EventHandler<ReportProgress> ReportProgress;

        public IAppLogger AppLogger { get; }

        public void DoWork()
        {
            this.AppLogger.AddInformation(
                $"Začátek importu z Toggl za období {this.appSetings.DateFrom.Date:d} - {this.appSetings.DateTo.Date:d}");

            var clients = this.GetClients();

            var projects = this.GetProjects();
            var invoiceCount = 0;

            var timeEntriesGroupedByClient = GetTimeEntriesGrouped(projects);

            var progress = 0;
            foreach (var timeEntries in timeEntriesGroupedByClient)
            {
                progress++;
                this.OnReportProgress(progress, timeEntriesGroupedByClient.Count);

                if (this.GenerateInvoice(timeEntries, clients, projects))
                {
                    invoiceCount++;
                }
            }

            this.AppLogger.AddInformation($"Konec impotu faktur, bylo importováno {invoiceCount} faktur.");
        }

        private IList<IGrouping<long?, TimeEntry>> GetTimeEntriesGrouped(IList<Project> projects)
        {
            if (appSetings.GroupTimeEntryBy == GroupTimeEntryBy.Clients)
            {
                return this.GetTimeEntriesGroupedByClient(projects);
            }

            return GetTimeEntriesGroupedByProject();
        }

        private void CreateAndSaveInvoice(Client client, IList<IssuedInvoiceItem> issuedInvoiceItems, IList<Project> projectsInInvoice)
        {
            if (issuedInvoiceItems.Count == 0)
            {
                return;
            }

            var api = this.dokladApiService.GetApiExplorer(
                this.appSetings.Doklad.Username,
                this.appSetings.Doklad.Password);

            var contact = this.FindContactByName(client.Name, api);
            if (contact == null || contact.Data.Count == 0)
            {
                this.AppLogger.AddError($"Ve službě iDokald nebyl nalezen kontakt {client.Name}.");
                return;
            }

            var purchaser = contact.Data.FirstOrDefault();

            var invoice = api.IssuedInvoices.Default();

            invoice.Description = GetInvoiceDescription(issuedInvoiceItems, projectsInInvoice);

            invoice.DateOfIssue = DateTime.SpecifyKind(invoice.DateOfIssue, DateTimeKind.Utc);
            invoice.DateOfMaturity = DateTime.SpecifyKind(invoice.DateOfMaturity, DateTimeKind.Utc);
            invoice.DateOfPayment = DateTime.SpecifyKind(invoice.DateOfPayment, DateTimeKind.Utc);
            invoice.DateOfTaxing = DateTime.SpecifyKind(invoice.DateOfTaxing, DateTimeKind.Utc);

            invoice.PurchaserId = purchaser?.Id ?? 0;
            invoice.CurrencyId = (int)this.appSetings.Currency;
            invoice.DiscountPercentage = purchaser?.DiscountPercentage ?? 0;
            invoice.IssuedInvoiceItems = issuedInvoiceItems;
            api.IssuedInvoices.Create(invoice);
        }

        private string GetInvoiceDescription(IList<IssuedInvoiceItem> issuedInvoiceItems, IList<Project> projectsInInvoice)
        {
            if (projectsInInvoice.Count == 0)
            {
                return issuedInvoiceItems[0].Name;
            }

            return projectsInInvoice.Select(x => x.Name).Aggregate((current, next) => current + ", " + next);
        }

        private IssuedInvoiceItem CreateInvoiceItem(string description, long duration, double hourlyRate)
        {
            return new IssuedInvoiceItem
                       {
                           Name = description,
                           Amount = Convert.ToDecimal(this.FormatDuration(duration)),
                           UnitPrice = Convert.ToDecimal(hourlyRate),
                           ItemType = IssuedInvoiceItemTypeEnum.ItemTypeNormal,
                           PriceType = this.appSetings.TypCeny,
                           VatRateType = this.appSetings.DruhSazby,
                           Unit = this.appSetings.Unit
                       };
        }

        private RowsResultWrapper<ContactExpand> FindContactByName(string clientName, ApiExplorer api)
        {
            var contactFilter = new ContactFilter();
            contactFilter.CompanyName.IsEqual(clientName);
            
            var contact = api.Contacts.ContactsExpand(new ApiFilter(contactFilter));
            return contact;
        }

        private double FormatDuration(long duration)
        {
            return this.timeFormaterService.FormatToNerestHalfHour(duration);
        }

        private bool GenerateInvoice(
            IGrouping<long?, TimeEntry> timeEntries,
            IList<Client> clients,
            IList<Project> projects)
        {
            if (timeEntries.Key == null)
            {
                this.AppLogger.AddError($"Nalezeny záznamy ve službě Toggl, bez vyplněného klienta.");
                return false;
            }

            var client = GetClientForInvice(timeEntries, clients, projects);
            if (client == null)
            {
                this.AppLogger.AddError($"Klient nenalezen na službě Toggl.");
                return false;
            }

            IList<Project> projectsInInvoice;
            var invoiceItems = this.GenerateInvoiceItems(timeEntries.ToList(), projects, out projectsInInvoice);
            this.CreateAndSaveInvoice(client, invoiceItems, projectsInInvoice);

            return true;
        }

        private Client GetClientForInvice(IGrouping<long?, TimeEntry> timeEntries, IList<Client> clients, IList<Project> projects)
        {
            if (appSetings.GroupTimeEntryBy == GroupTimeEntryBy.Clients)
            {
                return clients.FirstOrDefault(x => x.Id == timeEntries.Key.Value);
            }

            var project = projects.FirstOrDefault(x => x.Id == timeEntries.Key);
            return project == null ? null : clients.FirstOrDefault(x => x.Id == project.ClientId);
        }

        private List<IssuedInvoiceItem> GenerateInvoiceItems(
            IList<TimeEntry> timeEntries,
            IList<Project> projects,
            out IList<Project> projectsInInvoice)
        {
            var issuedInvoiceItems = new List<IssuedInvoiceItem>();
            projectsInInvoice = new List<Project>();

            var entriesByName = timeEntries.GroupBy(x => x.Description);
            foreach (var entries in entriesByName)
            {
                var project = entries.FirstOrDefault()?.GetProject(projects);
                var hourlyRate = project?.HourlyRate;
                if (hourlyRate == null)
                {
                    this.AppLogger.AddError($"Pro projekt {project?.Name} nebyla nastavena hodinová sazba.");
                    continue;
                }

                var duration = entries.Sum(x => x.Duration);
                if (duration.HasValue)
                {
                    issuedInvoiceItems.Add(this.CreateInvoiceItem(entries.Key, duration.Value, hourlyRate.Value));
                    if (projectsInInvoice.FirstOrDefault(x => x.Id == project.Id) == null)
                    {
                        projectsInInvoice.Add(project);
                    }
                }
            }

            return issuedInvoiceItems;
        }

        private IList<Client> GetClients()
        {
            var result = new List<Client>();
            var keys = this.appSetings.Toggl.GetApiKeys();
            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);
                result.AddRange(toggl.Client.List(), (x, y) => x.Id == y.Id);
            }

            return result;
        }

        private IList<Project> GetProjects()
        {
            if (appSetings.Project != null && appSetings.Project.ClientId > 0)
            {
                return new List<Project> { appSetings.Project };
            }

            var result = new List<Project>();
            var keys = this.appSetings.Toggl.GetApiKeys();
            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);
                result.AddRange(toggl.Project.List(), (x, y) => x.Id == y.Id);
            }

            return result;
        }
        
        private List<TimeEntry> GetTimeEntries()
        {
            var result = new List<TimeEntry>();
            var keys = this.appSetings.Toggl.GetApiKeys();

            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);

                var timeService = toggl.TimeEntry;

                // there is an issue with the date ranges have
                // to step out of the range on the end.
                // To capture the end of the billing range day + 1
                var prams = new TimeEntryParams();
                prams.StartDate = Convert.ToDateTime(this.appSetings.DateFrom.Date);
                prams.EndDate = Convert.ToDateTime(this.appSetings.DateTo.Date.AddDays(1));

                if (appSetings.Project != null && appSetings.Project.Id > 0)
                {
                    prams.ProjectId = appSetings.Project.Id;
                }

                var timeEntries = timeService.List(prams).Where(t => t.IsBillable.Value).ToList();
                result.AddRange(timeEntries);
            }

            return result;
        }

        private IList<IGrouping<long?, TimeEntry>> GetTimeEntriesGroupedByClient(IList<Project> projects)
        {
            var timeEntries = GetTimeEntries();
            var groupByClient = timeEntries.GroupBy(x => (long?)x.GetProject(projects).ClientId);
            return groupByClient.ToList();
        }
        
        private IList<IGrouping<long?, TimeEntry>> GetTimeEntriesGroupedByProject()
        {
            var timeEntries = GetTimeEntries();
            var groupByClient = timeEntries.Where(x => x.ProjectId > 0).GroupBy(x => x.ProjectId);
            return groupByClient.ToList();
        }

        private void OnReportProgress(int progress, int max)
        {
            if (this.ReportProgress != null)
            {
                var message = $"Generuji fakturu {progress}/{max}";
                this.ReportProgress.Invoke(this, new ReportProgress(progress, max, message));
            }
        }
    }
}
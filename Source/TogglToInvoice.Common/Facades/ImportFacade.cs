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

            var timeEntriesGroupedByClient = this.GetTimeEntriesGroupedByClient(projects);
            var progress = 0;
            foreach (var timeEntries in this.GetTimeEntriesGroupedByClient(projects))
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

        private void CreateAndSaveInvoice(Client client, IList<IssuedInvoiceItem> issuedInvoiceItems)
        {
            if (issuedInvoiceItems.Count == 0)
            {
                return;
            }

            var api = this.dokladApiService.GetApiExplorer(
                this.appSetings.Doklad.Username,
                this.appSetings.Doklad.Password);

            var contact = this.FindContactByName(client.Name, api);
            if (contact == null)
            {
                this.AppLogger.AddError($"Ve službě iDokald nebyl nalezen kontakt {client.Name}.");
                return;
            }

            var invoice = api.IssuedInvoices.Default();

            invoice.DateOfIssue = DateTime.SpecifyKind(invoice.DateOfIssue, DateTimeKind.Utc);
            invoice.DateOfMaturity = DateTime.SpecifyKind(invoice.DateOfMaturity, DateTimeKind.Utc);
            invoice.DateOfPayment = DateTime.SpecifyKind(invoice.DateOfPayment, DateTimeKind.Utc);
            invoice.DateOfTaxing = DateTime.SpecifyKind(invoice.DateOfTaxing, DateTimeKind.Utc);

            invoice.PurchaserId = contact.Data.FirstOrDefault()?.Id ?? 0;
            invoice.Description = issuedInvoiceItems[0].Name;
            invoice.CurrencyId = (int)this.appSetings.Currency;
            invoice.IssuedInvoiceItems = issuedInvoiceItems;
            api.IssuedInvoices.Create(invoice);
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
            return this.timeFormaterService.FormatToNerestQuarterHour(duration);
        }

        private bool GenerateInvoice(
            IGrouping<int?, TimeEntry> timeEntries,
            IList<Client> clients,
            IList<Project> projects)
        {
            if (timeEntries.Key == null)
            {
                this.AppLogger.AddError($"Nalezeny záznamy ve službě Toggl, bez vyplněného klienta.");
                return false;
            }

            var client = clients.FirstOrDefault(x => x.Id == timeEntries.Key.Value);
            if (client == null)
            {
                this.AppLogger.AddError($"Klient nenalezen na službě Toggl.");
                return false;
            }

            var invoiceItems = this.GenerateInvoiceItems(timeEntries, projects);
            this.CreateAndSaveInvoice(client, invoiceItems);

            return true;
        }

        private List<IssuedInvoiceItem> GenerateInvoiceItems(
            IGrouping<int?, TimeEntry> timeEntries,
            IList<Project> projects)
        {
            var issuedInvoiceItems = new List<IssuedInvoiceItem>();

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
                }
            }

            return issuedInvoiceItems;
        }

        private IList<Client> GetClients()
        {
            var toggl = new Toggl(this.appSetings.Toggl.ApiKey);
            return toggl.Client.List();
        }

        private IList<Project> GetProjects()
        {
            var toggl = new Toggl(this.appSetings.Toggl.ApiKey);
            return toggl.Project.List();
        }

        private IList<IGrouping<int?, TimeEntry>> GetTimeEntriesGroupedByClient(IList<Project> projects)
        {
            var toggl = new Toggl(this.appSetings.Toggl.ApiKey);

            var timeService = toggl.TimeEntry;

            // there is an issue with the date ranges have
            // to step out of the range on the end.
            // To capture the end of the billing range day + 1
            var prams = new TimeEntryParams();
            prams.StartDate = Convert.ToDateTime(this.appSetings.DateFrom.Date);
            prams.EndDate = Convert.ToDateTime(this.appSetings.DateTo.Date.AddDays(1));

            var timeEntries = timeService.List(prams).Where(t => t.IsBillable.Value).ToList();
            var groupByClient = timeEntries.GroupBy(x => x.GetProject(projects).ClientId);

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
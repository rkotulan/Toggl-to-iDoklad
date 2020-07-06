namespace TogglToInvoice.Common.Facades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IdokladSdk;
    using IdokladSdk.Models.Contact;
    using IdokladSdk.Models.IssuedInvoice;
    using IdokladSdk.Requests.Core.Modifiers.Filters;
    using IdokladSdk.Response;

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

        public ImportFacade(IDokladApiService dokladApiService, ITimeFormaterService timeFormaterService, IAppLogger appLogger, AppSetings appSetings)
        {
            this.dokladApiService = dokladApiService;
            this.timeFormaterService = timeFormaterService;
            this.appSetings = appSetings;
            AppLogger = appLogger;
        }

        public event EventHandler<ReportProgress> ReportProgress;

        public IAppLogger AppLogger { get; }

        public void DoWork()
        {
            AppLogger.AddInformation($"Začátek importu z Toggl za období {appSetings.DateFrom.Date:d} - {appSetings.DateTo.Date:d}");

            var clients = GetClients();

            var projects = GetProjects();
            var invoiceCount = 0;

            var timeEntriesGroupedByClient = GetTimeEntriesGrouped(projects);

            var progress = 0;
            foreach (var timeEntries in timeEntriesGroupedByClient)
            {
                progress++;
                OnReportProgress(progress, timeEntriesGroupedByClient.Count);

                if (GenerateInvoice(timeEntries, clients, projects))
                {
                    invoiceCount++;
                }
            }

            AppLogger.AddInformation($"Konec impotu faktur, bylo importováno {invoiceCount} faktur.");
        }

        private void CreateAndSaveInvoice(Client client, List<IssuedInvoiceItemPostModel> issuedInvoiceItems, IList<Project> projectsInInvoice)
        {
            if (issuedInvoiceItems.Count == 0)
            {
                return;
            }

            var api = dokladApiService.GetApiExplorer(appSetings.Doklad.Username, appSetings.Doklad.Password);
            
            var contact = this.FindContactByName(client.Name, api);
            if (contact == null || !contact.Data.Items.Any())
            {
                AppLogger.AddError($"Ve službě iDokald nebyl nalezen kontakt {client.Name}.");
                return;
            }

            var purchaser = contact.Data.Items.FirstOrDefault();
            var invoice = api.IssuedInvoiceClient.Default().Data;

            invoice.Description = GetInvoiceDescription(issuedInvoiceItems, projectsInInvoice);

            invoice.DateOfIssue = DateTime.SpecifyKind(invoice.DateOfIssue, DateTimeKind.Utc);
            invoice.DateOfMaturity = DateTime.SpecifyKind(invoice.DateOfMaturity, DateTimeKind.Utc);
            invoice.DateOfPayment = DateTime.SpecifyKind(invoice.DateOfPayment.Value, DateTimeKind.Utc);
            invoice.DateOfTaxing = DateTime.SpecifyKind(invoice.DateOfTaxing, DateTimeKind.Utc);

            invoice.PartnerId = purchaser?.Id ?? 0;
            invoice.CurrencyId = (int)appSetings.Currency;
            invoice.DiscountPercentage = purchaser?.DiscountPercentage ?? 0;
            invoice.Items = issuedInvoiceItems;
            api.IssuedInvoiceClient.Post(invoice);
        }

        private IssuedInvoiceItemPostModel CreateInvoiceItem(string description, long duration, double hourlyRate)
        {
            return new IssuedInvoiceItemPostModel
                       {
                           Name = description,
                           Amount = Convert.ToDecimal(FormatDuration(duration)),
                           UnitPrice = Convert.ToDecimal(hourlyRate),
                           ItemType = Doklad.Shared.Enums.Api.PostIssuedInvoiceItemType.ItemTypeNormal,
                           PriceType = appSetings.TypCeny,
                           VatRateType = appSetings.DruhSazby,
                           Unit = appSetings.Unit,
                           VatCodeId = 3 //// cleneni 01-02
                       };
        }

        private ApiResult<Page<ContactListGetModel>> FindContactByName(string clientName, DokladApi api)
        {
            var contactFilter = new ContactFilter();
            contactFilter.CompanyName.IsEqual(clientName);

            var contact = api.ContactClient.List().Filter(x => x.CompanyName.IsEqual(clientName)).Get();
            return contact;
        }

        private double FormatDuration(long duration)
        {
            return timeFormaterService.FormatToNerestHalfHour(duration);
        }

        private bool GenerateInvoice(IGrouping<long?, TimeEntry> timeEntries, IList<Client> clients, IList<Project> projects)
        {
            if (timeEntries.Key == null)
            {
                AppLogger.AddError($"Nalezeny záznamy ve službě Toggl, bez vyplněného klienta.");
                return false;
            }

            var client = GetClientForInvice(timeEntries, clients, projects);
            if (client == null)
            {
                AppLogger.AddError($"Klient nenalezen na službě Toggl.");
                return false;
            }

            IList<Project> projectsInInvoice;
            var invoiceItems = GenerateInvoiceItems(timeEntries.ToList(), projects, out projectsInInvoice);
            CreateAndSaveInvoice(client, invoiceItems, projectsInInvoice);

            return true;
        }

        private List<IssuedInvoiceItemPostModel> GenerateInvoiceItems(IList<TimeEntry> timeEntries, IList<Project> projects, out IList<Project> projectsInInvoice)
        {
            var issuedInvoiceItems = new List<IssuedInvoiceItemPostModel>();
            projectsInInvoice = new List<Project>();

            var entriesByName = timeEntries.GroupBy(x => x.Description);
            foreach (var entries in entriesByName)
            {
                var project = entries.FirstOrDefault()?.GetProject(projects);
                var hourlyRate = project?.HourlyRate;
                if (hourlyRate == null)
                {
                    AppLogger.AddError($"Pro projekt {project?.Name} nebyla nastavena hodinová sazba.");
                    continue;
                }

                var duration = entries.Sum(x => x.Duration);
                if (duration.HasValue)
                {
                    issuedInvoiceItems.Add(CreateInvoiceItem(entries.Key, duration.Value, hourlyRate.Value));
                    if (projectsInInvoice.FirstOrDefault(x => x.Id == project.Id) == null)
                    {
                        projectsInInvoice.Add(project);
                    }
                }
            }

            return issuedInvoiceItems;
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

        private IList<Client> GetClients()
        {
            var result = new List<Client>();
            var keys = appSetings.Toggl.GetApiKeys();
            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);
                result.AddRange(toggl.Client.List(), (x, y) => x.Id == y.Id);
            }

            return result;
        }

        private string GetInvoiceDescription(IList<IssuedInvoiceItemPostModel> issuedInvoiceItems, IList<Project> projectsInInvoice)
        {
            if (projectsInInvoice.Count == 0)
            {
                return issuedInvoiceItems[0].Name;
            }

            return projectsInInvoice.Select(x => x.Name).Aggregate((current, next) => current + ", " + next);
        }

        private IList<Project> GetProjects()
        {
            if (appSetings.Project != null && appSetings.Project.ClientId > 0)
            {
                return new List<Project> { appSetings.Project };
            }

            var result = new List<Project>();
            var keys = appSetings.Toggl.GetApiKeys();
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
            var keys = appSetings.Toggl.GetApiKeys();

            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);

                var timeService = toggl.TimeEntry;

                // there is an issue with the date ranges have
                // to step out of the range on the end.
                // To capture the end of the billing range day + 1
                var prams = new TimeEntryParams();
                prams.StartDate = Convert.ToDateTime(appSetings.DateFrom.Date);
                prams.EndDate = Convert.ToDateTime(appSetings.DateTo.Date.AddDays(1));

                if (appSetings.Project != null && appSetings.Project.Id > 0)
                {
                    prams.ProjectId = appSetings.Project.Id;
                }

                var timeEntries = timeService.List(prams).Where(t => t.IsBillable.Value).ToList();
                result.AddRange(timeEntries);
            }

            return result;
        }

        private IList<IGrouping<long?, TimeEntry>> GetTimeEntriesGrouped(IList<Project> projects)
        {
            if (appSetings.GroupTimeEntryBy == GroupTimeEntryBy.Clients)
            {
                return GetTimeEntriesGroupedByClient(projects);
            }

            return GetTimeEntriesGroupedByProject();
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
            if (ReportProgress != null)
            {
                var message = $"Generuji fakturu {progress}/{max}";
                ReportProgress.Invoke(this, new ReportProgress(progress, max, message));
            }
        }
    }
}
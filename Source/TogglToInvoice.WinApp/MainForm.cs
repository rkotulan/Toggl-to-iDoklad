namespace TogglToInvoice.WinApp
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Autofac;

    using IdokladSdk.Enums;

    using Syncfusion.Windows.Forms;

    using Toggl;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Enums;
    using TogglToInvoice.Common.Extensions;
    using TogglToInvoice.Common.Facades;
    using TogglToInvoice.Common.Infrastructure;
    using TogglToInvoice.Common.Infrastructure.LocalizableEnums;
    using TogglToInvoice.Common.Services;

    public partial class MainForm : MetroForm
    {
        private readonly AppSetings appSetings;

        private readonly ILocalizableEnumFactory localizableEnumFactory;

        private readonly ISettingsService settingsService;

        private bool projectLoaded = false;

        public MainForm(
            ISettingsService settingsService,
            ILocalizableEnumFactory localizableEnumFactory,
            AppSetings appSetings)
        {
            this.appSetings = appSetings;
            this.settingsService = settingsService;
            this.localizableEnumFactory = localizableEnumFactory;
            InitializeComponent();

            PrepareProjectCombo();
        }

        private void PrepareProjectCombo()
        {
            var projects = new List<Project>();
            projects.Add(new Project { Id = 0, Name = "vše" });

            cbProjekt.DisplayMember = "Name";
            cbProjekt.ValueMember = "Id";
            cbProjekt.DataSource = projects;
        }

        private void AutoSaveConfig()
        {
            if (appSetings.AutoSaveSettings)
            {
                settingsService.Save(appSetings);
            }
        }

        private void OnImportClick(object sender, EventArgs e)
        {
            using (var scope = Engine.Instance.BeginLifetimeScope())
            {
                using (var form = scope.Resolve<ProgressForm>())
                {
                    form.ShowDialog(this);
                }

                var importFacade = scope.Resolve<IImportFacade>();
                using (var form = new LogForm(importFacade.AppLogger))
                {
                    form.ShowDialog(this);
                }
            }

            AutoUpdateTimeRange();
            AutoSaveConfig();
        }

        private void AutoUpdateTimeRange()
        {
            if (appSetings.AutoUpdateInterval)
            {
                var span = appSetings.DateTo.Date - appSetings.DateFrom.Date;
                appSetings.DateFrom = appSetings.DateTo.Date.AddDays(1);
                appSetings.DateTo = appSetings.DateFrom.Add(span);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            tbTogglApiKey.DataBindings.Add("Text", appSetings, "Toggl.ApiKey");
            tbUserName.DataBindings.Add("Text", appSetings, "Doklad.Username");
            tbPassword.DataBindings.Add("Text", appSetings, "Doklad.Password");

            cbGroupBy.DataSource = localizableEnumFactory.CreateList<GroupTimeEntryBy>();
            cbGroupBy.DataBindings.Add(new Binding("SelectedValue", appSetings, "GroupTimeEntryBy"));

            dtpDateFrom.DataBindings.Add("Value", appSetings, "DateFrom");
            dtpDateTo.DataBindings.Add("Value", appSetings, "DateTo");

            cbTypCeny.DataSource = localizableEnumFactory.CreateList<PriceTypeEnum>();
            cbTypCeny.DataBindings.Add(new Binding("SelectedValue", appSetings, "TypCeny"));

            cbDruhSazby.DataSource = localizableEnumFactory.CreateList<VatRateTypeEnum>();
            cbDruhSazby.DataBindings.Add(new Binding("SelectedValue", appSetings, "DruhSazby"));

            cbMena.DataSource = localizableEnumFactory.CreateList<CurrencyEnum>();
            cbMena.DataBindings.Add(new Binding("SelectedValue", appSetings, "Currency"));

            tbJednotka.DataBindings.Add("Text", appSetings, "Unit");

            chbAutoSave.DataBindings.Add("Checked", appSetings, "AutoSaveSettings");
            chbAutoChangePeriod.DataBindings.Add("Checked", appSetings, "AutoUpdateInterval");

            cbProjekt.DataBindings.Add(new Binding("SelectedItem", appSetings, "Project"));
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            settingsService.Save(appSetings);
        }

        private void OnProjektDropDown(object sender, EventArgs e)
        {
            if (!projectLoaded)
            {
                Cursor = Cursors.WaitCursor;
                using (var scope = Engine.Instance.BeginLifetimeScope())
                {
                    var projectFacade = scope.Resolve<IToggleProjectFacade>();

                    try
                    {
                        var projects = projectFacade.GetProjects().OrderBy(x => x.Name).ToList();
                        projects.Insert(0, new Project { Id = 0, Name = "vše" });
                        cbProjekt.DataSource = projects;
                        projectLoaded = true;
                    }
                    catch
                    {
                        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                        MessageBoxAdv.Show(
                            this,
                            "Během přihlášení ke službě Toggl, nastala chyba.",
                            "Chyba",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                Cursor = Cursors.Default;
            }
            
            cbProjekt.ListBox.AutoSize = false;
            cbProjekt.ListBox.Size = new Size(cbProjekt.ListBox.Size.Width, 170);
        }
    }
}
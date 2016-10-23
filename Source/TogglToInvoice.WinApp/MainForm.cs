// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.WinApp
{
    using System;
    using System.Windows.Forms;

    using Autofac;

    using IdokladSdk.Enums;

    using Syncfusion.Windows.Forms;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Enums;
    using TogglToInvoice.Common.Facades;
    using TogglToInvoice.Common.Infrastructure;
    using TogglToInvoice.Common.Infrastructure.LocalizableEnums;
    using TogglToInvoice.Common.Services;

    public partial class MainForm : MetroForm
    {
        private readonly ISettingsService settingsService;

        private readonly ILocalizableEnumFactory localizableEnumFactory;
        
        private readonly AppSetings appSetings;

        public MainForm(
            ISettingsService settingsService,
            ILocalizableEnumFactory localizableEnumFactory,
            AppSetings appSetings)
        {
            this.appSetings = appSetings;
            this.settingsService = settingsService;
            this.localizableEnumFactory = localizableEnumFactory;
            this.InitializeComponent();
        }

        private void OnImportClick(object sender, EventArgs e)
        {
            this.AutoSaveConfig();

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
        }

        private void AutoSaveConfig()
        {
            if (this.appSetings.AutoSaveSettings)
            {
                this.settingsService.Save(this.appSetings);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.tbTogglApiKey.DataBindings.Add("Text", this.appSetings, "Toggl.ApiKey");
            this.tbUserName.DataBindings.Add("Text", this.appSetings, "Doklad.Username");
            this.tbPassword.DataBindings.Add("Text", this.appSetings, "Doklad.Password");

            this.dtpDateFrom.DataBindings.Add("Value", this.appSetings, "DateFrom");
            this.dtpDateTo.DataBindings.Add("Value", this.appSetings, "DateTo");

            this.cbTypCeny.DataSource = this.localizableEnumFactory.CreateList<PriceTypeEnum>();
            this.cbTypCeny.DataBindings.Add(new Binding("SelectedValue", this.appSetings, "TypCeny"));

            this.cbDruhSazby.DataSource = this.localizableEnumFactory.CreateList<VatRateTypeEnum>();
            this.cbDruhSazby.DataBindings.Add(new Binding("SelectedValue", this.appSetings, "DruhSazby"));

            this.cbMena.DataSource = this.localizableEnumFactory.CreateList<CurrencyEnum>();
            this.cbMena.DataBindings.Add(new Binding("SelectedValue", this.appSetings, "Currency"));

            this.tbJednotka.DataBindings.Add("Text", this.appSetings, "Unit");

            this.chbAutoSave.DataBindings.Add("Checked", this.appSetings, "AutoSaveSettings");
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            this.settingsService.Save(this.appSetings);
        }
    }
}
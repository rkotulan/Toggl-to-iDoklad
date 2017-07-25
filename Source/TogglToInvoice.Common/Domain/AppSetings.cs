// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppSetings.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Domain
{
    using System;

    using IdokladSdk.Enums;

    using PostSharp.Patterns.Model;

    using TogglToInvoice.Common.Enums;

    [NotifyPropertyChanged]
    public class AppSetings
    {
        public AppSetings()
        {
            this.Toggl = new TogglCfg();
            this.Doklad = new DokladCfg();

            this.DateFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            this.DateTo = DateTime.Today;
            this.AutoSaveSettings = true;
        }

        public DokladCfg Doklad { get; private set; }

        public TogglCfg Toggl { get; private set; }

        public PriceTypeEnum TypCeny { get; set; }

        public VatRateTypeEnum DruhSazby { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Unit { get; set; }

        public CurrencyEnum Currency { get; set; }

        public bool AutoSaveSettings { get; set; }

        public bool AutoUpdateInterval { get; set; }

        [NotifyPropertyChanged]
        public class DokladCfg
        {
            public string Username { get; set; }

            public string Password { get; set; }
        }

        [NotifyPropertyChanged]
        public class TogglCfg
        {
            public string ApiKey { get; set; }
        }
    }
}
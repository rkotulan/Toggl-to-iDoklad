﻿namespace TogglToInvoice.Common.Domain
{
    using System;
    using System.ComponentModel;

    using IdokladSdk.Enums;

    using Newtonsoft.Json;

    using Toggl;

    using TogglToInvoice.Common.Enums;

    // [NotifyPropertyChanged]
    public class AppSetings : INotifyPropertyChanged
    {
        public AppSetings()
        {
            Toggl = new TogglCfg();
            Doklad = new DokladCfg();

            DateFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTo = DateTime.Today;
            AutoSaveSettings = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool AutoSaveSettings { get; set; }

        public bool AutoUpdateInterval { get; set; }

        public CurrencyEnum Currency { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public DokladCfg Doklad { get; private set; }

        public VatRateType DruhSazby { get; set; }

        public GroupTimeEntryBy GroupTimeEntryBy { get; set; }

        [JsonIgnore]
        public Project Project { get; set; }

        public TogglCfg Toggl { get; private set; }

        public PriceType TypCeny { get; set; }

        public string Unit { get; set; }

        // [NotifyPropertyChanged]
        public class DokladCfg : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public string Password { get; set; }

            public string Username { get; set; }
        }

        // [NotifyPropertyChanged]
        public class TogglCfg : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public string ApiKey { get; set; }
        }

        
    }
}
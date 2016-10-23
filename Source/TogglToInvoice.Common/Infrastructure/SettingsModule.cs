// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsModule.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure
{
    using Autofac;

    using TogglToInvoice.Common.Services;

    public class SettingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var settingsService = new SettingsService();
            var settings = settingsService.Load();
            builder.RegisterInstance(settings).ExternallyOwned();
        }
    }
}
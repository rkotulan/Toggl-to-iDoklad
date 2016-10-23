// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISettingsService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using TogglToInvoice.Common.Domain;

    public interface ISettingsService
    {
        AppSetings Load();

        void Save(AppSetings appSetings);
    }
}
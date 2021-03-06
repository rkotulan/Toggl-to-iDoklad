﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDokladApiService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using IdokladSdk;

    public interface IDokladApiService
    {
        DokladApi GetApiExplorer(string username, string password);
    }
}
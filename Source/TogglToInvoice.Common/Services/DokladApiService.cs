// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DokladApiService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using IdokladSdk;
    using IdokladSdk.Clients;
    using IdokladSdk.Clients.Auth;

    public class DokladApiService : IDokladApiService
    {
        public ApiExplorer GetApiExplorer(string username, string password)
        {
            var credentials = new ClientCredentialAuth(username, password);
            var apiContext = new ApiContext(credentials) { AppName = "Toggle to iDoklad" };
            return new ApiExplorer(apiContext);
        }
    }
}
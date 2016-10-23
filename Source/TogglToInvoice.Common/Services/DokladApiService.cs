// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DokladApiService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using IdokladSdk;
    using IdokladSdk.Clients;

    public class DokladApiService : IDokladApiService
    {
        public ApiExplorer GetApiExplorer(string username, string password)
        {
            var authClient = new OAuthClient(username, password);
            var apiContext = new ApiContext(authClient.GetSecureToken()) { AppName = "Toggle to iDoklad" };
            return new ApiExplorer(apiContext);
        }
    }
}
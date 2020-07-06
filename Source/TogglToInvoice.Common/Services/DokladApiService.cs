namespace TogglToInvoice.Common.Services
{
    using IdokladSdk;
    using IdokladSdk.Authentication;

    public class DokladApiService : IDokladApiService
    {
        public DokladApi GetApiExplorer(string username, string password)
        {
            var credentials = new ClientCredentialsAuthentication(username, password);
            var apiContext = new ApiContext("Toggle to iDoklad", "2.0", credentials);
            return new DokladApi(apiContext);
        }
    }
}
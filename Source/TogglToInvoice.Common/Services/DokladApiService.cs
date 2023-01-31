namespace TogglToInvoice.Common.Services
{
    using System.Net.Http;

    using IdokladSdk;
    using IdokladSdk.Builders;

    public class DokladApiService : IDokladApiService
    {
        public DokladApi GetApiExplorer(string username, string password)
        {
            var apiContext = new DokladApiBuilder("Toggle to iDoklad", "2.0")
                .AddClientCredentialsAuthentication(username, password)
                .AddHttpClient(new HttpClient())
                .Build();
            return apiContext;
        }
    }
}
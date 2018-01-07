namespace TogglToInvoice.Common.Extensions
{
    using System.Collections.Generic;

    using TogglToInvoice.Common.Domain;

    public static class TogglCfgExtensions
    {
        public static IList<string> GetApiKeys(this AppSetings.TogglCfg toggleCfg)
        {
            return toggleCfg.ApiKey.Split(';');
        }
    }
}
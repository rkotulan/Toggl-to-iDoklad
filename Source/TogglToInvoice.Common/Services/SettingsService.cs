// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using System;
    using System.IO;

    using Newtonsoft.Json;

    using TogglToInvoice.Common.Domain;

    public class SettingsService : ISettingsService
    {
        public AppSetings Load()
        {
            var fileName = this.GetConfigFullName();
            if (!File.Exists(fileName))
            {
                return new AppSetings();                
            }
            
            var configContent = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<AppSetings>(configContent);
        }

        public void Save(AppSetings appSetings)
        {
            var contents = JsonConvert.SerializeObject(appSetings);
            var fileName = this.GetConfigFullName();
            File.WriteAllText(fileName, contents);
        }

        private string GetConfigFullName()
        {
            string roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var path = Path.Combine(roaming, "TogglToInvoice");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return Path.Combine(path, "AppConfig.json");
        }
    }
}
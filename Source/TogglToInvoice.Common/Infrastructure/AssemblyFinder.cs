// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyFinder.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class AssemblyFinder
    {
        private const string AssemblyLoadNamePrefix = "TogglToInvoice";

        private readonly string[] allowedExtensions = { ".dll", ".exe" };

        public List<Assembly> GetAssemblies()
        {
            var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).Where(
                f =>
                    {
                        var fileInfo = new FileInfo(f);
                        return fileInfo.Name.Contains(AssemblyLoadNamePrefix)
                               && this.allowedExtensions.Contains(fileInfo.Extension);
                    }).ToList();

            return files.Select(Assembly.LoadFile).ToList();
        }
    }
}
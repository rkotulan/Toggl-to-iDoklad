// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppLogger.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using System;
    using System.Collections.Generic;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Enums;

    public class AppLogger : IAppLogger
    {
        public AppLogger()
        {
            this.LogItems = new List<LogItem>();
        }

        public IList<LogItem> LogItems { get; set; }

        public void AddError(string message)
        {
            this.AddMessage(LogSeverity.Error, DateTime.Now, message);
        }

        public void AddError(Exception exception)
        {
            this.AddError(exception.Message);
        }

        public void AddInformation(string message)
        {
            this.AddMessage(LogSeverity.Information, DateTime.Now, message);
        }

        public void AddMessage(LogSeverity logSeverity, DateTime date, string message)
        {
            this.LogItems.Add(new LogItem { LogSeverity = logSeverity, Date = date, Message = message });
        }

        public void AddWarning(string message)
        {
            this.AddMessage(LogSeverity.Warning, DateTime.Now, message);
        }
    }
}
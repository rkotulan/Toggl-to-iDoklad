// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAppLogger.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using System;
    using System.Collections.Generic;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Enums;

    public interface IAppLogger
    {
        IList<LogItem> LogItems { get; }

        void AddError(string message);

        void AddError(Exception exception);

        void AddInformation(string message);

        void AddMessage(LogSeverity logSeverity, DateTime date, string message);

        void AddWarning(string message);
    }
}
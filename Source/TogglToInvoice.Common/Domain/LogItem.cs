// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogItem.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Domain
{
    using System;

    using TogglToInvoice.Common.Enums;

    public class LogItem
    {
        public DateTime Date { get; set; }

        public LogSeverity LogSeverity { get; set; }

        public string Message { get; set; }
    }
}
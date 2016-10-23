// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportProgress.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure.BackgroundFacade
{
    public class ReportProgress
    {
        public ReportProgress(int progress, int max, string message)
        {
            this.Progress = progress;
            this.Max = max;
            this.Meassage = message;
        }

        public int Max { get; set; }

        public string Meassage { get; set; }

        public int Progress { get; set; }
    }
}
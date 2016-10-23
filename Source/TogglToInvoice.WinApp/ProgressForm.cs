// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProgressForm.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.WinApp
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    using Syncfusion.Windows.Forms;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Infrastructure.BackgroundFacade;

    public partial class ProgressForm : MetroForm
    {
        private readonly AppSetings appConfig;

        private readonly IBackgroundFacade backgroundFacade;

        private readonly BackgroundWorker backgroundWorker;

        public ProgressForm(IBackgroundFacade backgroundFacade)
        {
            if (backgroundFacade == null)
            {
                throw new ArgumentNullException(nameof(backgroundFacade));
            }

            this.InitializeComponent();

            this.backgroundFacade = backgroundFacade;
            this.backgroundFacade.ReportProgress += this.OnFacadeReportProgress;

            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += this.DoWork;
            this.backgroundWorker.ProgressChanged += this.OnProgressChanged;
            this.backgroundWorker.RunWorkerCompleted += this.OnRunWorkerCompleted;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            this.backgroundFacade.DoWork();
        }

        private void OnFacadeReportProgress(object sender, ReportProgress e)
        {
            this.backgroundWorker.ReportProgress(0, e);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.backgroundWorker.IsBusy)
            {
                e.Cancel = true;
            }
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var reportProgress = (ReportProgress)e.UserState;

            this.lblMainText.Text = reportProgress.Meassage;
            this.pbProgress.Maximum = reportProgress.Max;
            this.pbProgress.Value = reportProgress.Progress;
        }

        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.backgroundFacade.AppLogger.AddError(e.Error);
            }

            this.Close();
        }

        private void OnShown(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }
    }
}
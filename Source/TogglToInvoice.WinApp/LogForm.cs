// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogForm.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.WinApp
{
    using Syncfusion.Windows.Forms;

    using TogglToInvoice.Common.Services;

    public partial class LogForm : MetroForm
    {
        public LogForm(IAppLogger appLogger)
        {
            this.InitializeComponent();

            this.ReportGrid.DataSource = appLogger.LogItems;
        }
    }
}
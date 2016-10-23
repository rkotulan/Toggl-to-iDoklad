// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.WinApp
{
    using System;
    using System.Windows.Forms;

    using Autofac;

    using TogglToInvoice.Common.Infrastructure;

    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = Engine.Instance.BeginLifetimeScope())
            {
                Application.Run(scope.Resolve<MainForm>());
            }
        }
    }
}
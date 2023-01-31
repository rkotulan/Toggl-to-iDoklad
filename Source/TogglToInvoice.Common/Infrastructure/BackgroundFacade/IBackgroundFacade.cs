// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBackgroundFacade.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure.BackgroundFacade
{
    using System;
    using System.Threading.Tasks;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Services;

    public interface IBackgroundFacade
    {
        event EventHandler<ReportProgress> ReportProgress;

        IAppLogger AppLogger { get; }

        void DoWork();
    }
}
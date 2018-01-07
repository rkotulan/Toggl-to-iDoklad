// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITimeFormaterService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    public interface ITimeFormaterService
    {
        double FormatToNerestQuarterHour(double seconds);

        double FormatToNerestHalfHour(double seconds);
    }
}
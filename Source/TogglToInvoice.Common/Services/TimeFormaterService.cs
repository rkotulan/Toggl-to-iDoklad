// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeFormaterService.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Services
{
    using System;

    public class TimeFormaterService : ITimeFormaterService
    {
        public double FormatToNerestQuarterHour(double seconds)
        {
            var timeSpan = TimeSpan.FromSeconds(seconds);

            var minutes = timeSpan.TotalHours - Math.Truncate(timeSpan.TotalHours);
            var hours = timeSpan.TotalHours - minutes;
            minutes = this.RoundUpToQuarterHour(minutes);

            return hours + minutes;
        }

        public double FormatToNerestHalfHour(double seconds)
        {
            var timeSpan = TimeSpan.FromSeconds(seconds);

            var minutes = timeSpan.TotalHours - Math.Truncate(timeSpan.TotalHours);
            var hours = timeSpan.TotalHours - minutes;
            minutes = this.RoundUpToHalfHour(minutes);

            return hours + minutes;
        }

        private double RoundUpToQuarterHour(double val)
        {
            if (val <= 0)
            {
                return 0;
            }

            if (val <= 0.25)
            {
                return 0.25;
            }

            if (val <= 0.50)
            {
                return 0.50;
            }

            if (val <= 0.75)
            {
                return 0.75;
            }

            return 1;
        }

        private double RoundUpToHalfHour(double val)
        {
            if (val <= 0)
            {
                return 0;
            }

            if (val <= 0.50)
            {
                return 0.50;
            }

            return 1;
        }
    }
}
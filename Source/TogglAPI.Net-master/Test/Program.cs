// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Test
{
    using System;
    using System.Linq;

    using Toggl.QueryObjects;
    using Toggl.Services;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            var apiKey = "14f0519043ed68fbe560e044f8928326";
            var timeEntryService = new TimeEntryService(apiKey);

            var prams = new TimeEntryParams();

            // there is an issue with the date ranges have
            // to step out of the range on the end.
            // To capture the end of the billing range day + 1
            prams.StartDate = Convert.ToDateTime("20.4.2015");
            prams.EndDate = Convert.ToDateTime("27.4.2015");

            var list = timeEntryService.List(prams)
                                    .Where(w => !string.IsNullOrEmpty(w.Description));

            //var list = timeEntryService.List();
            foreach (var timeEntry in list)
            {
                
            }
        }

        #endregion
    }
}
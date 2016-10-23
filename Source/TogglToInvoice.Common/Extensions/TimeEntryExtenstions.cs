// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeEntryExtenstions.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using Toggl;

    public static class TimeEntryExtenstions
    {
        public static Project GetProject(this TimeEntry timeEntry, IEnumerable<Project> projects)
        {
            return projects.FirstOrDefault(x => x.Id == timeEntry.ProjectId) ?? new Project { Name = "Nepřiřazen" };
        }
    }
}
namespace TogglToInvoice.Common.Facades
{
    using System.Collections.Generic;

    using Toggl;

    public interface IToggleProjectFacade
    {
        IList<Project> GetProjects();
    }
}
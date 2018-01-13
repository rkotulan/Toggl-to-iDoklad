using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogglToInvoice.Common.Facades
{
    using Toggl;

    using TogglToInvoice.Common.Domain;
    using TogglToInvoice.Common.Extensions;

    public class ToggleProjectFacade : IToggleProjectFacade
    {
        private readonly AppSetings appSetings;

        public ToggleProjectFacade(AppSetings appSetings)
        {
            this.appSetings = appSetings;
        }

        public IList<Project> GetProjects()
        {
            var result = new List<Project>();
            var keys = this.appSetings.Toggl.GetApiKeys();
            foreach (var apiKey in keys)
            {
                var toggl = new Toggl(apiKey);
                result.AddRange(toggl.Project.List(), (x, y) => x.Id == y.Id);
            }

            return result;
        }
    }
}

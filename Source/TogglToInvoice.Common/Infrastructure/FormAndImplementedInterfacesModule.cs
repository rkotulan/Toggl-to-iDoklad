// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormAndImplementedInterfacesModule.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure
{
    using System.Windows.Forms;

    using Autofac;

    public class FormAndImplementedInterfacesModule : Module
    {
        private readonly AssemblyFinder assemblyFinder;

        public FormAndImplementedInterfacesModule()
        {
            this.assemblyFinder = new AssemblyFinder();
        }

        protected override void Load(ContainerBuilder builder)
        {
            foreach (var assembly in this.assemblyFinder.GetAssemblies())
            {
                builder.RegisterAssemblyTypes(assembly).AssignableTo<Form>().InstancePerLifetimeScope();
                builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            }
        }
    }
}
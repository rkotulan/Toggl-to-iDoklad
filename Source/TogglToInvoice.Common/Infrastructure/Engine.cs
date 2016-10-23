// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Engine.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure
{
    using Autofac;

    public class Engine
    {
        private readonly IContainer container;

        static Engine()
        {
            Instance = new Engine();
        }

        public Engine()
        {
            var builder = new ContainerBuilder();
            var assemblyFinder = new AssemblyFinder();

            assemblyFinder.GetAssemblies().ForEach(a => builder.RegisterAssemblyModules(a));

            this.container = builder.Build();
        }

        public static Engine Instance { get; }

        public ILifetimeScope BeginLifetimeScope()
        {
            return this.container.BeginLifetimeScope();
        }
    }
}
using System;
using Autofac;
using Haapanen.ConsoleApp.IoCDemo.Services;

namespace Haapanen.ConsoleApp.IoCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();

            var application = container.Resolve<Application>();

            application.Run(args);
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // Register all services (classes where name ends in "Service" and exist in same assembly 
            // as ExampleService
            builder.RegisterAssemblyTypes(typeof(ExampleService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            // Register a single class
            builder.RegisterType(typeof(CustomClass));
            builder.RegisterType(typeof(Application));

            return builder.Build();
        }
    }
}

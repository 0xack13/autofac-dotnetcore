using System;
using Autofac;

namespace consoleapps
{
    class Program
    {
        private static IContainer Container {get; set;}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDataWriter>();
            Container = builder.Build();
            WriteDate();
        }

        public static void WriteDate() {
            using(var scope=Container.BeginLifetimeScope()) {
                var writer = scope.Resolve<IDataWriter>();
                writer.writeDate();
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceLifetimeDemo
{
    // Separate interfaces for each lifetime
    public interface ISingletonService
    {
        void DoWork();
    }

    public interface ITransientService
    {
        void DoWork();
    }

    public interface IScopedService
    {
        void DoWork();
    }

    // Implementations
    public class SingletonService : ISingletonService
    {
        private readonly Guid _id = Guid.NewGuid();

        public void DoWork()
        {
            Console.WriteLine($"Singleton Instance ID: {_id}");
        }
    }

    public class TransientService : ITransientService
    {
        private readonly Guid _id = Guid.NewGuid();

        public void DoWork()
        {
            Console.WriteLine($"Transient Instance ID: {_id}");
        }
    }

    public class ScopedService : IScopedService
    {
        private readonly Guid _id = Guid.NewGuid();

        public void DoWork()
        {
            Console.WriteLine($"Scoped Instance ID: {_id}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create service provider
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISingletonService, SingletonService>()
                .AddTransient<ITransientService, TransientService>()
                .AddScoped<IScopedService, ScopedService>()
                .BuildServiceProvider();

            Console.WriteLine("---- Singleton ----");
            var singleton1 = serviceProvider.GetService<ISingletonService>();
            var singleton2 = serviceProvider.GetService<ISingletonService>();

            singleton1.DoWork();
            singleton2.DoWork();
            Console.WriteLine($"Same instance: {singleton1 == singleton2}");

            Console.WriteLine("\n---- Transient ----");
            var transient1 = serviceProvider.GetService<ITransientService>();
            var transient2 = serviceProvider.GetService<ITransientService>();

            transient1.DoWork();
            transient2.DoWork();
            Console.WriteLine($"Same instance: {transient1 == transient2}");

            Console.WriteLine("\n---- Scoped ----");
            using (var scope1 = serviceProvider.CreateScope())
            {
                var scoped1 = scope1.ServiceProvider.GetService<IScopedService>();
                var scoped2 = scope1.ServiceProvider.GetService<IScopedService>();

                scoped1.DoWork();
                scoped2.DoWork();
                Console.WriteLine($"Same instance in same scope: {scoped1 == scoped2}");
            }

            using (var scope2 = serviceProvider.CreateScope())
            {
                var scoped3 = scope2.ServiceProvider.GetService<IScopedService>();
                scoped3.DoWork();
            }

            Console.ReadLine();
        }
    }
}

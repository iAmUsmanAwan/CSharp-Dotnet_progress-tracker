using Microsoft.Extensions.DependencyInjection;
using System;

namespace ServiceLifetimeDemo
{
    // ================================
    // 1. INTERFACES (Contracts)
    // ================================     
    // Separate interfaces for each lifetime because it avoids confusion about which lifetime is being resolved.
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

    // ================================
    // 2. IMPLEMENTATIONS
    // ================================
    // Each class generates a UNIQUE Guid when it is created.
    // If the Guid stays the same → SAME INSTANCE
    // If the Guid changes → NEW INSTANCE

    public class SingletonService : ISingletonService
    {
        // Created ONCE for the entire application
        private readonly Guid _id = Guid.NewGuid();

        public void DoWork()
        {
            Console.WriteLine($"Singleton Instance ID: {_id}");
        }
    }

    public class TransientService : ITransientService
    {
        // Created EVERY TIME it is requested
        private readonly Guid _id = Guid.NewGuid();

        public void DoWork()
        {
            Console.WriteLine($"Transient Instance ID: {_id}");
        }
    }

    public class ScopedService : IScopedService
    {
        // Created ONCE per SCOPE
        // (same inside one scope, different in another scope)
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
            // ================================
            // 3. SERVICE REGISTRATION
            // ================================
            // This is the Dependency Injection container.
            // Here we tell .NET:
            //  - WHICH interface maps to WHICH class
            //  - HOW LONG that object should live

            var serviceProvider = new ServiceCollection()

                // Singleton → one instance for entire app lifetime
                .AddSingleton<ISingletonService, SingletonService>()

                // Transient → new instance every time you ask
                .AddTransient<ITransientService, TransientService>()

                // Scoped → one instance per scope (request / unit of work)
                .AddScoped<IScopedService, ScopedService>()
                .BuildServiceProvider();

            // ================================
            // 4. SINGLETON TEST
            // ================================
            Console.WriteLine("---- Singleton ----");

            // Both calls return the SAME object
            var singleton1 = serviceProvider.GetService<ISingletonService>();
            var singleton2 = serviceProvider.GetService<ISingletonService>();

            singleton1.DoWork();
            singleton2.DoWork();
            Console.WriteLine($"Same instance: {singleton1 == singleton2}");    // True → same memory reference

            // ================================
            // 5. TRANSIENT TEST
            // ================================
            Console.WriteLine("\n---- Transient ----");

            // Each call creates a NEW object
            var transient1 = serviceProvider.GetService<ITransientService>();
            var transient2 = serviceProvider.GetService<ITransientService>();

            transient1.DoWork();
            transient2.DoWork();
            Console.WriteLine($"Same instance: {transient1 == transient2}");    // False → different memory references

            // ================================
            // 6. SCOPED TEST (Same Scope)
            // ================================

            // Create FIRST scope
            Console.WriteLine("\n---- Scoped ----");
            using (var scope1 = serviceProvider.CreateScope())
            {
                // Both resolved from SAME scope
                var scoped1 = scope1.ServiceProvider.GetService<IScopedService>();
                var scoped2 = scope1.ServiceProvider.GetService<IScopedService>();

                scoped1.DoWork();
                scoped2.DoWork();
                Console.WriteLine($"Same instance in same scope: {scoped1 == scoped2}");   // True → same instance INSIDE one scope
            }

            // ================================
            // 7. SCOPED TEST (Different Scope)
            // ================================
            using (var scope2 = serviceProvider.CreateScope())
            {
                // New scope → NEW scoped instance
                var scoped3 = scope2.ServiceProvider.GetService<IScopedService>();
                scoped3.DoWork();
            }

            Console.ReadLine();
        }
    }
}

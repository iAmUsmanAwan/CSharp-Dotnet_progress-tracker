using Microsoft.VisualBasic;

namespace C_Injection_MultiThreading
{
    public interface IAccount
    {
        Task PrintDetailsAsync();
    }

    class SavingAccount : IAccount
    {
        public async Task PrintDetailsAsync()
        {
            await Task.Delay(50); // simulate DB / IO work
            Console.WriteLine("This is a Saving Account.");
        }
    }

    // Account class depends on IAccount (not a concrete class)
    // This is Constructor Dependency Injection
    class Account
    {
        // Readonly reference ensures the dependency
        // cannot be changed after object creation
        private readonly IAccount account;

        // Dependency is injected at runtime
        public Account(IAccount account)
        {
            this.account = account;
        }

        // Async method that delegates work to the injected dependency
        public async Task PrintAccountDetailsAsync()
        {
            // Await ensures proper async flow (no thread blocking)
            await account.PrintDetailsAsync();

            Console.WriteLine("Account Details Printed");
        }
    }

    class UmerAccount
    {
        private readonly IAccount account;

        // SemaphoreSlim is used instead of 'lock' because it works safely with async/await
        // Allows only ONE thread to enter at a time
        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        // Dependency Injection again
        public UmerAccount(IAccount account)
        {
            this.account = account;
        }

        // Async method with thread-safe access
        public async Task PrintAccountDetailsAsync()
        {
            // WaitAsync does NOT block the thread
            // It asynchronously waits for the lock
            await _semaphore.WaitAsync();         // async-safe lock
            try
            {
                await account.PrintDetailsAsync();

                // Simulate additional processing
                await Task.Delay(100);
                
                Console.WriteLine("Umer Account Details Printed");
            }
            finally
            {
                // Always release the semaphore even if an exception occurs
                _semaphore.Release();
            }
        }
    }

    class Program
    {
        // Async Main allows awaiting tasks directly
        static async Task Main(string[] args)
        {
            // Create ONE shared SavingAccount instance
            IAccount sa = new SavingAccount();

            // Inject the same dependency into multiple consumers
            Account account1 = new Account(sa);
            UmerAccount account2 = new UmerAccount(sa);

            // Run both async methods concurrently
            // Task.WhenAll waits until BOTH complete
            await Task.WhenAll(
                account1.PrintAccountDetailsAsync(),
                account2.PrintAccountDetailsAsync()
            );

            Console.ReadLine();
        }
    }
}

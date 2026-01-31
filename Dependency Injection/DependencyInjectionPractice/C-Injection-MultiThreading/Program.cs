using Microsoft.VisualBasic;

namespace C_Injection_MultiThreading
{
    // Interface that defines a contract for Account types
    // Any class implementing IAccount MUST provide PrintDetails()
    public interface IAccount
    {
        void PrintDetails();
    }

    // Concrete implementation of IAccount
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a Current Account.");
        }
    }

    // Another concrete implementation of IAccount
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a Saving Account.");
        }
    }

    // Account class depends on IAccount (NOT a concrete class)
    // This is Dependency Injection via constructor
    class Account
    {
        // Interface reference → allows polymorphism
        private IAccount account;

        // Constructor Injection
        // At runtime, any class implementing IAccount can be passed
        public Account(IAccount account)
        {
            this.account = account;
        }

        // calls the injector's PrintDetails method
        public void PrintAccountDetails()
        {
            account.PrintDetails();
            Console.WriteLine("Account Details Printed");
        }
    }

    // Another class using the SAME IAccount object
    // Demonstrates multithreading + synchronization
    class UmerAccount
    {
        private IAccount account;
        object Lock;

        // Constructor Injection again
        public UmerAccount(IAccount account)
        {
            this.account = account;
        }
        public void PrintAccountDetails()
        {
            // Runs the code on a separate thread
            Task.Run( () => {
                            // lock ensures that only ONE thread
                            // can access this account object at a time
                    lock (account)
                                    {
                                        account.PrintDetails();
                                        Task.Delay(100);  // Simulates some delay / long-running work
                    Console.WriteLine("Umer Account Details Printed");
                                    }
                                }
                    ).GetAwaiter();   // Starts execution (but not awaited properly)
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create ONE SavingAccount object
            IAccount sa = new SavingAccount();

            // Inject the SAME SavingAccount into multiple classes
            Account account2 = new Account(sa);
            
            UmerAccount account3 = new UmerAccount(sa);

            // Run both methods on separate threads
            Task.Run(() => account2.PrintAccountDetails());

            Task.Run(() => account3.PrintAccountDetails());

            Console.ReadLine();
        }
    }
}
namespace PropertyInjection
{

    public interface IAccount  // Injector
    {
        void PrintDetails();    // the method created in the interface donot have a body (Abstract method)
    }

    class CurrentAccount : IAccount   // implementing the interface   (service classes)
    {
        public void PrintDetails()   // providing the body of the method
        {
            Console.WriteLine("This is a Current Account.");
        }
    }

    class SavingAccount : IAccount   // (service classes)
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a Saving Account.");
        }
    }

    class Account // {dependent class} depenrds on the IAccount interface (Client Class)
    {
        public required IAccount account { get; set; }  // property injection

        public void PrintAccountDetails()    // method of the client class
        {
            account.PrintDetails();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account
            {
                account = new SavingAccount()
            };

            sa.PrintAccountDetails();
            Console.ReadLine();

            Account ca = new Account
            {
                account = new CurrentAccount()
            };
            ca.PrintAccountDetails();
            Console.ReadLine();

        }
    }
}
namespace ConstructorInjection
{
    //// //Tight Coupling Example
    //class CurrentAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("This is a Current Account.");
    //    }
    //}
    //class SavingAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("This is a Saving Account.");
    //    }
    //}
    //class Account
    //{
    //    CurrentAccount ca = new CurrentAccount();
    //    SavingAccount sa = new SavingAccount();

    //    public void PrintAccountDetails()
    //    {
    //        ca.PrintDetails();
    //        sa.PrintDetails();
    //    }
    //}

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
        private IAccount account;

        // Constructor Injection
        public Account(IAccount account)  // parameterized constructor
        {
            this.account = account;
        }
        public void PrintAccountDetails()
        {
            account.PrintDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // // Tight Coupling
            //Account a = new Account();
            //a.PrintAccountDetails();

            // Loose Coupling using Dependency Injection
            IAccount ca = new CurrentAccount();   // the child class object is created and assigned to the interface reference of the parent type
            Account account1 = new Account(ca);   // injecting the dependency through constructor
            account1.PrintAccountDetails();

            IAccount sa = new SavingAccount();
            Account account2 = new Account(sa);
            account2.PrintAccountDetails();

            Console.ReadLine();
        }
    }
}
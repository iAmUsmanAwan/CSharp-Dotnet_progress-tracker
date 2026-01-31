namespace Method_Injection
{
    public interface IAccount
    {
        void PrintDetails();
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a Current Account.");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a Saving Account.");
        }
    }

    // Account class does NOT store IAccount as a field
    // Dependency is injected directly into the method
    class Account
    {
        // The dependency (IAccount) is passed as a parameter
        // This method works with ANY account type
        public void PrintAccountDetails(IAccount account)
        {
            account.PrintDetails();
            Console.WriteLine("Account Details Printed");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            // Inject SavingAccount dependency at method call
            sa.PrintAccountDetails(new SavingAccount());

            // Same Account class, different dependency
            Account ca = new Account();
            ca.PrintAccountDetails(new CurrentAccount());

            Console.ReadLine();
        }
    }
}

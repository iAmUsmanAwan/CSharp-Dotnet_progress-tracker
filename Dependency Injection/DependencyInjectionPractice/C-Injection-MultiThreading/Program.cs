using Microsoft.VisualBasic;

namespace C_Injection_MultiThreading
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

    class Account
    {
        private IAccount account;

        public Account(IAccount account)
        {
            this.account = account;
        }
        public void PrintAccountDetails()
        {
            account.PrintDetails();
            Console.WriteLine("Account Details Printed");
        }
    }

    class UmerAccount
    {
        private IAccount account;
        object Lock;

        public UmerAccount(IAccount account)
        {
            this.account = account;
        }
        public void PrintAccountDetails()
        {
            Task.Run(
                        () => {
                            lock (account)
                                {
                                    account.PrintDetails();
                                    Task.Delay(100);
                                    Console.WriteLine("Umer Account Details Printed");
                                }
                            }
                    ).GetAwaiter();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            IAccount sa = new SavingAccount();
            
            Account account2 = new Account(sa);
            
            UmerAccount account3 = new UmerAccount(sa);
            
            Task.Run(() => account2.PrintAccountDetails());

            Task.Run(() => account3.PrintAccountDetails());

            Console.ReadLine();
        }
    }
}
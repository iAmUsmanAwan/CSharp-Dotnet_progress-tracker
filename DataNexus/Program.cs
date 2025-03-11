using DataNexus.PresentationLayer;

namespace DataNexus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.ShowCustomerMenu();
            Console.WriteLine("Hello, World!");
        }
    }
}

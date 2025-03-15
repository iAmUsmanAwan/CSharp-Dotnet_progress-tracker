using DataNexus.BusinessLogicLayer;
using DataNexus.BusinessObjects;
using DataNexus.PresentationLayer;

namespace DataNexus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomerUI customerUI = new CustomerUI();
            //customerUI.ShowCustomerMenu();
            //Console.WriteLine("Hello, World!");



            CustomerService customerService = new CustomerService();

            Console.WriteLine("Enter Customer Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customer Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Customer newCustomer = new Customer
            {
                Name = name,
                Email = email,
                Address = new CustomerAddress
                {
                    Address = address,
                    City = city,
                    State = state
                }
            };

            customerService.RegisterCustomer(newCustomer);
            Console.WriteLine("Customer Registered Successfully!");

            // Fetch and display customer details
            Customer fetchedCustomer = customerService.GetCustomerDetails(id);
            if (fetchedCustomer != null)
            {
                Console.WriteLine("\nRetrieved Customer:");
                Console.WriteLine($"ID: {fetchedCustomer.CustomerID}, Name: {fetchedCustomer.Name}, Email: {fetchedCustomer.Email}");
                Console.WriteLine($"Address: {fetchedCustomer.Address.Address}, City: {fetchedCustomer.Address.City}, State: {fetchedCustomer.Address.State}");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataNexus.BusinessObjects;
using DataNexus.DataAccessLayer;

namespace DataNexus.BusinessLogicLayer
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Enter customer name:");
            if (string.IsNullOrEmpty(customer.Name))
                throw new ArgumentException("Customer name is required");

            _customerRepository.Add(customer);
        }
    }

}

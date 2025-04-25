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
        //private readonly CustomerRepository _customerRepository = new CustomerRepository();

        //public void AddCustomer(Customer customer)
        //{
        //    Console.WriteLine("Enter customer name:");
        //    if (string.IsNullOrEmpty(customer.Name))
        //        throw new ArgumentException("Customer name is required");

        //    _customerRepository.Add(customer);
        //}


        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void RegisterCustomer(Customer customer)
        {
            // Business Validation
            if (string.IsNullOrWhiteSpace(customer.Name))
                throw new ArgumentException("Customer name cannot be empty.");

            if (string.IsNullOrWhiteSpace(customer.Email))
                throw new ArgumentException("Email cannot be empty.");

            if (customer.Address == null || string.IsNullOrWhiteSpace(customer.Address.Address))
                throw new ArgumentException("Address is required.");

            _customerRepository.AddCustomer(customer);
        }

        public Customer GetCustomerDetails(int customerId)
        {
            return _customerRepository.GetCustomer(customerId);
        }


    }

}

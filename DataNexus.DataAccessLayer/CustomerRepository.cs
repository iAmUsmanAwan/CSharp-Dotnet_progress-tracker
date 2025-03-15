using System;
using DataNexus.BusinessObjects;
using Microsoft.Data.SqlClient;


namespace DataNexus.DataAccessLayer
{
    //public class CustomerRepository
    //{
        //public void add()
        //{
        //    Console.WriteLine("CustomerRepository.add() called");
        //}

        //public void Add(Customer customer)
        //{
        //    //throw new NotImplementedException();
        //    this.add();
        //}
    //}


    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CustomerID, Name, Email FROM Customers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                CustomerID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return customers;
        }

        public Customer GetCustomer(int customerId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CustomerID, Name, Email FROM Customers WHERE CustomerID = @CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                CustomerID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return null; // Return null if customer not found
        }
    }



}


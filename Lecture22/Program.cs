using System;
using Microsoft.Data.SqlClient;

namespace Lecture22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyNewDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            /// We will get input from user and make changes to the table User

            Console.Write("Enter the User Name :");
            string userName = Console.ReadLine();

            Console.Write("Enter the Password :");
            string Password = Console.ReadLine();


            //string query = "insert into Users(UserName, Password) values('user', '123')";   // Hardcoded inputed user

            /// To insert user from the input 
            string query = $"insert into Users(UserName, Password) values('{userName}', '{Password}')";


            /// To update user from the input
            //string query = $"Update Users set Password = '{Password}' where UserName = '{userName}'";


            /// To delete user from the input
            //string query = $"delete Users where UserName = '{userName}'";


            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        int insertedRows = cmd.ExecuteNonQuery();  // we use ExecuteNonQuery to execute Update/Insert/Delete query  { and returns number of rows affected }
                        
                        if (insertedRows >= 1)
                        {
                            Console.WriteLine("Row Affected (Inserted/Updated/Deleted)");
                        }
                        else
                        {
                            Console.WriteLine("Failed");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred while executing the SQL command.");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine($"Error Number: {ex.Number}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }



        }
    }
}

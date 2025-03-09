using System;
using Microsoft.Data.SqlClient;

namespace Lecture21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";  // from the right click on the db and properties 

            SqlConnection conn = new SqlConnection(connString);   // create the connection

            conn.Open();   // database connected with application

            string query = "Select * from person";  // query to run

            SqlCommand cmd = new SqlCommand(query, conn);   // run the query , and tell which connection to use 

            SqlDataReader reader = cmd.ExecuteReader();   // to read the data recieved from the Query { reference }

            while (reader.Read())    // execute till finds rows
            {
                Console.WriteLine($"Id : {reader.GetValue(0)}, Name : {reader[1]}, Age : {reader.GetValue(2)} ");
            }


        }
    }
}

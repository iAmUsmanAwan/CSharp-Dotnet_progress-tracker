using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using Microsoft.Data.SqlClient;

namespace Lec21_23_ADO
{
    public class PersonRepository
    {
        private readonly DatabaseHelper dbHelper;

        public PersonRepository(string connectionString)
        {
            dbHelper = new DatabaseHelper(connectionString);
        }

        // Create Person
        public void AddPerson(Person person)
        {
            using (var connection = dbHelper.GetConnection())
            {
                string query = "INSERT INTO dbo.Person (Name, Age) VALUES (@Name, @Age)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", person.Name);
                command.Parameters.AddWithValue("@Age", person.Age);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Read Person
        public Person GetPerson(int id)
        {
            using (var connection = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM dbo.Person WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Person
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Age = (int)reader["Age"]
                    };
                }
            }
            return null;
        }

        // Update Person
        public void UpdatePerson(Person person)
        {
            using (var connection = dbHelper.GetConnection())
            {
                string query = "UPDATE dbo.Person SET Name = @Name, Age = @Age WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@Name", person.Name);
                command.Parameters.AddWithValue("@Age", person.Age);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Delete Person
        public void DeletePerson(int id)
        {
            using (var connection = dbHelper.GetConnection())
            {
                string query = "DELETE FROM dbo.Person WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Get All Persons
        public List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();

            using (var connection = dbHelper.GetConnection())
            {
                string query = "SELECT * FROM dbo.Person";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    persons.Add(new Person
                    {
                        Id = (int)reader.GetValue(0), //AS in sir video 
                        Name = reader["Name"].ToString(), // as in dic
                        Age = (int)reader[2] //AS in sir video
                    });
                }
            }
            return persons;
        }
        // Delete Persons with Name Starting with 'A'
        public void DeletePersonsStartingWithA()
        {
            using (var connection = dbHelper.GetConnection())
            {
                string query = "DELETE FROM Person WHERE Name LIKE 'A%'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool LoginWithSqlInjection(string name, int age)
        {
            string query = $"SELECT COUNT(*) FROM dbo.Person WHERE Name = '{name}' AND Age = {age}";

            using (var connection = dbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool LoginWithoutSqlInjectionSqlParameter(string name, int age)
        {
            string query = "SELECT COUNT(*) FROM dbo.Person WHERE Name = @Name AND Age = @Age";

            using (var connection = dbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

    }
}






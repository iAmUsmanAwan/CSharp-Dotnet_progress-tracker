using BussinessObjects;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Lec21_23_ADO
{
    public static class Class1
    {
        public static void PrintSomething()
        {
            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ADO_LEC_21_23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //Using DataBase Helper To Make initial Connection 
            DatabaseHelper databaseHelper = new DatabaseHelper(ConnectionString);
            var x = databaseHelper.GetConnection();
            //x.Open();


            var PersonReader = new PersonRepository(ConnectionString);

            // Execute the delete function
            //PersonReader.DeletePersonsStartingWithA();



            //WE CAN ACHEIVE SAME SENARIO WITH ANOTHER IMPLEMENTATION
            //LUN QUERY IMLEMENTATION
            //ACTUAL NAME 
            //LINQ / LAMDA EXP
            //var PersonDataVariable = PersonReader.GetAllPersons();
            List<Person> actualModelPersonDataVariable = PersonReader.GetAllPersons();
            
            
            var PersonStartAsayyy = actualModelPersonDataVariable.Where(x => x.Name.StartsWith("U")).ToList();
           
            foreach (var Per in PersonStartAsayyy)
            {
                PersonReader.DeletePerson(Per.Id);
            }


            

            int asuhfash = 19;    // just to stop the debugger from exiting the execution

        }
    }
}

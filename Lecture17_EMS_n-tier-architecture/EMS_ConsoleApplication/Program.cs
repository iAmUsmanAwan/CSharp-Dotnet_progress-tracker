using EMS_BLL;
using EMS_BO;
using System;

namespace EMS_ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Welcome to Employee Management System!--");

            // User Input for Employee Name
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            // User Input for Employee Age with Validation
            int age;
            while (true) // Loop until a valid age is entered
            {
                Console.Write("Enter Age: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    break; // Valid age, exit loop
                }
                Console.WriteLine("❌ Invalid age. Please enter a valid number greater than 0.");
            }

            EmployeeBLL employeeBLL = new EmployeeBLL();  // Create an EmployeeBO object with Name and Age


            /// Created some object to pass it to BLL , No matter if it is being used in BLL or not , We only created this because it was a parameter(dependency) of the saveEmployee function 

            //EmployeeBO SomeObject = new EmployeeBO() { Age = 55, Name = "Hamza", Salary = 10000 };
            //EmployeeBO SomeOtherObject = new EmployeeBO() { Age = 30, Name = "Khalid" };


            //Now we will pass that someobject to the function and lets debug iit :D

            //employeeBLL.SaveEmployee(SomeObject);
            //employeeBLL.SaveEmployee(SomeOtherObject);


            // Create EmployeeBO object with user input
            EmployeeBO newEmployee = new EmployeeBO() { Name = name, Age = age };

            // Save Employee Data
            employeeBLL.SaveEmployee(newEmployee);

            Console.WriteLine("Employee saved successfully!");


        }
    }
}

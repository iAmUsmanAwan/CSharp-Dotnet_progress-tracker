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

            //Console.Write("Enter Employee Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Age: ");
            //if (!int.TryParse(Console.ReadLine(), out int age))
            //{
            //    Console.WriteLine("Invalid age. Please enter a valid number.");
            //    return;
            //}

            EmployeeBLL employeeBLL = new EmployeeBLL();  // Create an EmployeeBO object with Name and Age

            /// Created some object to pass it to BLL , No matter if it is being used in BLL or not , We only created this because it was a parameter(dependency) of the saveEmployee function 
            EmployeeBO SomeObject = new EmployeeBO() { Age = 13, Name = "Ahmed", Salary = 10000 };
            EmployeeBO SomeOtherObject = new EmployeeBO() { Age = 23, Name = "Ali" };


            //Now we will pass that someobject to the function and lets debug iit :D
            employeeBLL.SaveEmployee(SomeObject);
            employeeBLL.SaveEmployee(SomeOtherObject);


        }
    }
}

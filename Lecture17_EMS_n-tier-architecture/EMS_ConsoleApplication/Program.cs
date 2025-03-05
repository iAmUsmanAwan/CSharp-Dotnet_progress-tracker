using EMS_BLL;
using EMS_BO;

namespace EMS_ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            EmployeeBLL employeeBLL = new EmployeeBLL();
            
            
            
            //Created some object to pass it to bll 
            // No matter if it is being used in bll or not
            //We only created this because it was a parameter(dependency) of the saveEmployee function 
            EmployeeBO SomeObject = new EmployeeBO() { Age = 13, Name = "Ahmed", Salary = 10000 };






            //Now we will pass that someobject to the function and lets debug iit :D
            employeeBLL.SaveEmployee(SomeObject);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_BLL;
using EMS_BO;

namespace EMS_View
{
    public class EmployeeView
    {    // we will define how to get input from the user in this layer this is directly called from the console application
        public void GetInput()
        {
            Console.WriteLine("Enter Employee Name: ");
            string ?empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            int age = System.Convert.ToInt32( Console.ReadLine());
            
            EmployeeBO bo = new EmployeeBO{Name = empName, Age = age };  // Here we have assigned the values to the object of EmployeeBO class (this information will be sent into Business logic layer)

            EmployeeBLL bll = new EmployeeBLL();
            bll.SaveEmployee(bo);

        }
    }
}

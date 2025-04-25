using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS_BO;
using EMS_DAL;

namespace EMS_BLL
{
    public class EmployeeBLL
    {      // here we define the business, (also in case of any change in future we will change only Business Logic Layer) 
        public void SaveEmployee( EmployeeBO bo)
        {
            if ( bo.Age <= 20 )
            {
                bo.Salary = 10_000;
            } 
            else if ( bo.Age > 20 && bo.Age < 50 )
            {
                bo.Salary = 40_000;
            }
            else
            {
                bo.Salary = 70_000;
            }

            EmployeeDAL dal = new EmployeeDAL();

            dal.SaveEmployee(bo);   // passing the bo object to dal object of EmployeeDAL
            
        }
    }
}

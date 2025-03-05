using System;
using EMS_BO;

namespace EMS_DAL
{
    public class EmployeeDAL : BaseDAL
    {
        public void SaveEmployee(EmployeeBO bo)
        {
            string text = $"{bo.Name}, {bo.Age}, {bo.Salary}";  // here we are converting the data in string form
            Save(text, "EmployeeData.csv");   // saving the text in (EmployeeData.csv) file

        }
    }
}

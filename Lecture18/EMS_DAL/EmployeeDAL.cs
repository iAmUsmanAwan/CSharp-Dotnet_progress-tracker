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

        public List<EmployeeBO> ReadEmployee() 
        { 
            List<String> stringList = Read("EmployeeData.csv");

            List<EmployeeBO> empList = new List<EmployeeBO>();
            
            foreach (string s in stringList) 
            {
                string[] data = s.Split(",");
                // Ensure the data array has exactly 3 values
                if (data.Length < 3)
                {
                    Console.WriteLine($"Invalid data format: {s}");
                    continue;  // Skip this iteration if data is incomplete
                }

                EmployeeBO e = new EmployeeBO();
                e.Name = data[0];

                if (int.TryParse(data[1], out int age))
                {
                    e.Age = age;
                }
                else
                {
                    Console.WriteLine($"Invalid Age Format: {data[1]}");
                    continue;
                }

                if (int.TryParse(data[2], out int salary))
                {
                    e.Salary = salary;
                }
                else
                {
                    Console.WriteLine($"Invalid Salary Format: {data[2]}");
                    continue;
                }

                empList.Add(e);
            
            }
            return empList;

        }

    }
}

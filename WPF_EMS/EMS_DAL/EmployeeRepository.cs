using EMS_BO;
using System.Globalization;

namespace EMS_DAL;
public class EmployeeRepository : IEmployeeRepository
{
    private readonly string _filePath = "employees.csv";

    public void SaveEmployee(Employee employee)
    {
        var line = $"{employee.Name},{employee.FatherName},{employee.CNIC},{employee.Designation}," +
                  $"{employee.DateOfBirth:yyyy-MM-dd},{employee.Gender},{employee.Department},{employee.IsManager}";
        File.AppendAllText(_filePath, line + Environment.NewLine);
    }

    public List<Employee> GetAllEmployees()
    {
        if (!File.Exists(_filePath)) return new List<Employee>();

        return File.ReadAllLines(_filePath)
            .Select(line => line.Split(','))
            .Select(data => new Employee
            {
                Name = data[0],
                FatherName = data[1],
                CNIC = data[2],
                Designation = data[3],
                DateOfBirth = DateTime.ParseExact(data[4], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Gender = data[5],
                Department = data[6],
                IsManager = bool.Parse(data[7])
            }).ToList();
    }
}
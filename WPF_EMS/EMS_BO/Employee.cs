using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_BO;
public class Employee
{
    public string? Name { get; set; }
    public string? FatherName { get; set; }
    public string? CNIC { get; set; }
    public string? Designation { get; set; }
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
    public string? Gender { get; set; }
    public string? Department { get; set; }
    public bool IsManager { get; set; }
}
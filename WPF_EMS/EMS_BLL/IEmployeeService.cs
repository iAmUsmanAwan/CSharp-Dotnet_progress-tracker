using EMS_BO;
namespace EMS_BLL;
public interface IEmployeeService
{
    void SaveEmployee(Employee employee);
    List<Employee> GetAllEmployees();
}
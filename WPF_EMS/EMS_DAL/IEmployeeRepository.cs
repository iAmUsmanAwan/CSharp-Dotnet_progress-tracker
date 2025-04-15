using EMS_BO;
namespace EMS_DAL;
public interface IEmployeeRepository
{
    void SaveEmployee(Employee employee);
    List<Employee> GetAllEmployees();
}
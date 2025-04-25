using EMS_BO;
using EMS_DAL;
namespace EMS_BLL;
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public void SaveEmployee(Employee employee) => _repository.SaveEmployee(employee);
    public List<Employee> GetAllEmployees() => _repository.GetAllEmployees();
}
using EMS_BLL;
using EMS_BO;
using EMS_DAL;
using EMS_View.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace EMS_View.ViewModels;
public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private readonly IEmployeeService _employeeService;

    private Employee _currentEmployee = new();
    public Employee CurrentEmployee
    {
        get => _currentEmployee;
        set
        {
            if (_currentEmployee != value)
            {
                _currentEmployee = value;
                OnPropertyChanged();
            }
        }
    }

    public ObservableCollection<Employee> Employees { get; } = new();
    public List<string> Genders { get; } = new() { "Male", "Female", "Other" };
    public List<string> Departments { get; } = new() { "R&D", "QA", "Production", "Accounts", "Admin" };

    public ICommand SaveCommand { get; }
    public ICommand LoadCommand { get; }

    private string? _statusMessage;
    public string? StatusMessage
    {
        get => _statusMessage;
        set
        {
            if (_statusMessage != value)
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }
    }

    public MainViewModel() : this(new EmployeeService(new EmployeeRepository()))
    {
    }

    public MainViewModel(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
        SaveCommand = new RelayCommand(_ => SaveEmployee());
        LoadCommand = new RelayCommand(_ => LoadEmployees());
        CurrentEmployee = new Employee();
    }

    private void SaveEmployee()
    {
        StatusMessage = "Saving employee...";
        try
        {
            _employeeService.SaveEmployee(CurrentEmployee);
            MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            CurrentEmployee = new Employee(); // Reset form
            StatusMessage = "Employee saved successfully!";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving employee: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            StatusMessage = $"Error saving employee: {ex.Message}";
        }
    }

    private void LoadEmployees()
    {
        try
        {
            Employees.Clear();
            var employees = _employeeService.GetAllEmployees();
            foreach (var emp in employees)
            {
                Employees.Add(emp);
            }
            MessageBox.Show($"Loaded {employees.Count} employees", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
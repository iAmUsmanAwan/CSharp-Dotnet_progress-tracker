using EMS_BLL;  // For IEmployeeService
using EMS_DAL;  // For IEmployeeRepository
using EMS_View.ViewModels;
using EMS_View.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace EMS_View
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();  // From EMS_DAL
            services.AddSingleton<IEmployeeService, EmployeeService>();      // From EMS_BLL
            services.AddSingleton<MainViewModel>();                          // From ViewModels
            services.AddSingleton<MainWindow>();                            // From Views

            var provider = services.BuildServiceProvider();
            provider.GetRequiredService<MainWindow>().Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lecture38_Part_2
{
    /// this is also known as RelayCommand, by using delegate commands to simplify the code

    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private readonly Action<string> _execute;
        private readonly Predicate<string> _canExecute;

        public DelegateCommand(Action<string> e, Predicate<string> c)
        {
            _execute = e;
            _canExecute = c;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute(parameter as string ?? "");
        }

        public void Execute(object? parameter)
        {
            _execute(parameter as string ?? "");
        }
    }
}

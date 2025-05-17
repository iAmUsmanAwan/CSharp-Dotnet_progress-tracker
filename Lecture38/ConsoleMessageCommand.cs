using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lecture38
{

    class ConsoleMessageCommand : ICommand
    {
        /// All of this logic is same as MessageCommand except the below mentioned

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private MessageViewModel messagevm;

        public ConsoleMessageCommand(MessageViewModel vm)     // here the constructor name is changed
        {
            this.messagevm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return messagevm.canExecute(parameter as string);
        }
        public void Execute(object? parameter)
        {
            messagevm.DisplayMessageOnConsole(parameter as string);    // here the method name is changed in comparison to MessageCommand
        }
    }
}

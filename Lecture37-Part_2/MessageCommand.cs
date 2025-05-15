using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lecture37_Part_2
{
    class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private MessageViewModel messagevm;

        public MessageCommand(MessageViewModel vm)
        {
            this.messagevm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return messagevm.canExecute(parameter);
        }
        public void Execute(object? parameter)
        {
            messagevm.DisplayMessage(parameter);
        }
    }
}

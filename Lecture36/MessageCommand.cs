using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Lecture36
{
    class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MessageViewModel messagevm;

        public MessageCommand(MessageViewModel vm)
        {
            this.messagevm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            // to maintain the state of the button
            return true;
            // if we want to disable the button then we will return false
        }
        public void Execute(object? parameter)
        {
            messagevm.DisplayMessage();
        }
    }
    
}


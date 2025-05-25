﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lecture41.Command
{
    class DelegateCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged;
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        private Action<object> _execute;
        //        private Func<object, bool> _canExecute;
        private Predicate<object> _canExecute;
        public DelegateCommand(Action<object> e, Predicate<object> c)
        {
            this._execute = e;
            this._canExecute = c;
        }
        public bool CanExecute(object parameter)
        {

            return this._canExecute(parameter as string);
        }

        public void Execute(object parameter)
        {
            this._execute(parameter as string);
        }

    }
}

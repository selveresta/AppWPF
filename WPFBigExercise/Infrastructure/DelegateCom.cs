using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPFBigExercise.Infrastructure
{
    class DelegateCom : ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DelegateCom(Action<object> exec, Func<object, bool> canExec = null)
        {
            execute = exec;
            canExec = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}

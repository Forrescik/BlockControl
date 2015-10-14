using System;
using System.Windows.Input;

namespace BlockControl
{
    public class DelegateCommand : ICommand
    {
        private Action<object> action;
        public DelegateCommand(Action<object> action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}

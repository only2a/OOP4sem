using _6_7_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _6_7_8.Commands
{
    public class DeleteElementCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<Product> _execute;

        public DeleteElementCommand(Action<Product> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as Product);
        }
    }
}

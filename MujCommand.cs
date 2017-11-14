using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IFSfractals
{
    public class MujCommand : ICommand
    {
        Action _action;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public MujCommand(Action action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("Stistknul si tlačítko");
            _action?.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_ICommand
{
    public class RemoveCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var nameList = parameter as NameList;
            var oldName = nameList.SelectedName;
            nameList.Names.Remove(oldName);
        }

        public bool CanExecute(object parameter)
        {
            var nameList = parameter as NameList;
            return nameList != null && nameList.SelectedName != null;
        }

        public event EventHandler CanExecuteChanged
        {                                 
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}

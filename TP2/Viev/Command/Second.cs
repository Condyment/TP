using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TP2.Viev.Command
{
   public  class Second : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action executee;
        public Second(Action executee)
        {
            
            this.executee = executee;


        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executee.Invoke();
        }
    }
}

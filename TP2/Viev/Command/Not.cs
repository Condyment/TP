using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Viev.Command
{
   public class Not : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void onepropretychanged(string proprety)
        {
            if (PropertyChanged != null)
            {


                PropertyChanged(this, new PropertyChangedEventArgs(proprety));

            }


        }
    }
}

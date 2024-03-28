using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp7.Model;

namespace WpfApp7.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public Model.BankAccount ba1;

        // constructor
        public MainWindowViewModel()
        {
            ba1 = new Model.BankAccount(100);
            MyAccount = ba1;
        }
      
        public BankAccount MyAccount { 
            
            get { return ba1; } 
            set {
                ba1 = value;
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

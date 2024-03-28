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
        private  Model.BankAccount _ba1;

        // constructor
        public MainWindowViewModel()
        {
            _ba1 = new Model.BankAccount(100);
            // make the viewmodel the listener of the model
            MyAccount = _ba1;
        }
      
        public BankAccount MyAccount { 
            
            get { return _ba1; } 
            set {
                _ba1 = value;
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

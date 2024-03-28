using System;
using System.ComponentModel;
using System.Data.Odbc;

namespace WpfApp7.Model
{
    internal class BankAccount : INotifyPropertyChanged
    {
       

        // fields
        private decimal _saldo;

        // constructor
        public BankAccount(decimal saldo)
        {
            _saldo = saldo;
          
        }

        // properties
        public decimal Balance { 
            get {
                return _saldo;
            } 
            set {
                _saldo = value;
                OnPropertyChanged("Balance");
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        // methods
        public void Deposit(decimal amount)
        {
            _saldo += amount;
            Balance = _saldo;
            OnPropertyChanged("Balance");

        }

        public Boolean Withdraw(decimal amount)
        {
            // not allowed to withdraw more than the saldo
            if (amount > _saldo)
            {
                return false;
            }
            _saldo -= amount;
            Balance = _saldo;
            OnPropertyChanged("Balance");

            return true;
        }

       
        
    }
}

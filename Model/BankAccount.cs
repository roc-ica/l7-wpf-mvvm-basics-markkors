using System;

namespace WpfApp7.Model
{
    internal class BankAccount 
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
           /* set {
                _saldo = value;
            } */
        }

        


        // methods
        public void Deposit(decimal amount)
        {
            _saldo += amount;

        }

        public Boolean Withdraw(decimal amount)
        {
            // not allowed to withdraw more than the saldo
            if (amount > _saldo)
            {
                return false;
            }
            _saldo -= amount;

            return true;
        }

       
        
    }
}

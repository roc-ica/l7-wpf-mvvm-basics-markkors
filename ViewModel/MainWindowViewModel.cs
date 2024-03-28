using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp7.Model;

namespace WpfApp7.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        // create a Generic List of bankaccounts
        private List<BankAccount> _bankaccounts = new List<BankAccount>();
        private BankAccount _SelectedBankAccount;

        // commands
        public ICommand DepositCommand { get; }
        public ICommand WithdrawCommand { get; }


        // constructor
        public MainWindowViewModel()
        {
            // create a random number generator
            Random rnd = new Random();
            // fill the list with 5 bankaccounts
            for (int i = 0; i < 5; i++)
            {
                // add a random amount of money to the bankaccount
                string number = "NL45 ABN " + rnd.Next(100000000, 999999999).ToString();
                _bankaccounts.Add(new BankAccount(rnd.Next(100, 1000),number));

            }

            // Initialize your commands
            DepositCommand = new RelayCommand(DoDeposit);
            WithdrawCommand = new RelayCommand(DoWithdraw);

            BankAccounts = _bankaccounts.ToArray();

            // set the first bankaccount as the selected one
            SelectedBankAccount = _bankaccounts[0];
            
        }

        private void DoDeposit(object parameter)
        {
            if (parameter is string amountString && decimal.TryParse(amountString, out decimal amount))
            {
                SelectedBankAccount.Deposit(amount);
            }
        }

        private void DoWithdraw(object parameter)
        {
            if (parameter is string amountString && decimal.TryParse(amountString, out decimal amount))
            {
                SelectedBankAccount.Withdraw(amount);
            }
        }

        public BankAccount[] BankAccounts { get; set; }

        public BankAccount SelectedBankAccount
        {
            get { return _SelectedBankAccount; }
            set { 
                _SelectedBankAccount = value;
                OnPropertyChanged("SelectedBankAccount");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

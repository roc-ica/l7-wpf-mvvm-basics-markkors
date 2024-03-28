using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.Model;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private BankAccount ba1;
        public MainWindow()
        {
            InitializeComponent();
            ba1 = new BankAccount(100);
            // update the display
            updateDisplay();
        }

        #region methods
        private void updateDisplay()
        {
            txtBalance.Text = ba1.Balance.ToString("C");
        }
        #endregion


        #region event handlers


        private void doDeposit(object sender, RoutedEventArgs e)
        {


            decimal amount = decimal.Parse(txtAmount.Text);
            ba1.Deposit(amount);
            updateDisplay();
        }

        private void doWithdraw(object sender, RoutedEventArgs e)
        {
            decimal amount = decimal.Parse(txtAmount.Text);
            ba1.Withdraw(amount);
            updateDisplay();
        }

        #endregion


    }
}

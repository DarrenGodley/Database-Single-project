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
using System.Windows.Shapes;

namespace ATM.BackEnd
{
    /// <summary>
    /// Interaction logic for Balance.xaml
    /// </summary>
    public partial class Balance : Window
    {
        public Balance()
        {
            //this would be taken from the database
            Account myAcc = new Account(1001, 12000, 'C', false);

            InitializeComponent();
            txtBal.Text = myAcc.getBalance().ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var menuForm = new MainMenu();
            menuForm.Show();
            this.Close();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}

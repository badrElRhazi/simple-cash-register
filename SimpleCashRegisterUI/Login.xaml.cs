using SimpleCashRegisterLibrary.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SimpleCashRegisterUI
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        CashierManager cashierManager = new CashierManager();

        public Login()
        {
            InitializeComponent();
            clearError();
            if (cashierManager.Count() == 0)
            {
                buttonLogin.Content = "Sign Up";
            }
        }
        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(nom.Text) && !string.IsNullOrEmpty(password.Password.ToString()))
            {
                if(cashierManager.Login(nom.Text, password.Password.ToString()))
                {
                    clearError();
                    ItemsPage page = new ItemsPage();
                    this.Visibility = Visibility.Hidden;
                    Application.Current.MainWindow.Visibility = Visibility.Hidden;
                    page.Show();
                }
                else
                {
                    ErrorLabel.Visibility = Visibility.Visible;
                    ErrorLabel.Content = "* Invalid info";
                }
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "* Fill all fields";
            }
        }
        /*string name = itemNameTextBox.Text;
        string description = itemDescriptionTextBox.Text;
        CashierManager c = new CashierManager();
        c.addCashier(name, description);*/
        public void clearError()
        {
            ErrorLabel.Visibility = Visibility.Hidden;
        }

        /*private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {
            string name = nom.Text;
            string description = password.Password;
            CashierManager c = new CashierManager();
            c.addCashier(name, description);
        }*/
        private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nom.Text) && !string.IsNullOrEmpty(password.Password.ToString()))
            {
                string name = nom.Text;
                    string pass = password.Password;
                    CashierManager c = new CashierManager();
                    c.addCashier(name, pass);
                    nom.Clear();
                    password.Clear();
                    clearError();
                    ItemsPage page = new ItemsPage();
                    this.Visibility = Visibility.Hidden;
                    Application.Current.MainWindow.Visibility = Visibility.Hidden;
                    page.Show();
                
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "* Fill all fields";
            }
        }
    }
}

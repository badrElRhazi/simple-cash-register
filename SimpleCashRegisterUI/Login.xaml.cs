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
        private MainWindow mainWindow;

        public Login(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
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

                    Artikl artikel = new Artikl();
                    mainWindow.CC.Content= artikel;
                    MessageBox.Show("welcome the store !");
                    
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
       
        public void clearError()
        {
            ErrorLabel.Visibility = Visibility.Hidden;
        }
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
                    Artikl artikel = new Artikl();
                    mainWindow.CC.Content = artikel;
                    MessageBox.Show("welcome the store !");

            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "* Fill all fields";
            }
        }
    }
}

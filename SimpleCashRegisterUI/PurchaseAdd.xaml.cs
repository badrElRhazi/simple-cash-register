using SimpleCashRegisterLibrary.Business;
using SimpleCashRegisterLibrary.Model;
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

namespace SimpleCashRegisterUI
{
    /// <summary>
    /// Logique d'interaction pour PurchaseAdd.xaml
    /// </summary>
    public partial class PurchaseAdd : UserControl
    {
        private MainWindow mainw;
        public PurchaseAdd()
        {
            InitializeComponent();
            clearError();
        }
        PurchaseManager purchaseManager = new PurchaseManager();
        ItemManager itemManager = new ItemManager();
        List<Shopping> shoppingList = new List<Shopping>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(itemNumberTextBox.Text) && !string.IsNullOrEmpty(discountTextBox.Text))
            {
                clearError();
                purchaseManager.AddToCart(int.Parse(itemNumberTextBox.Text), float.Parse(discountTextBox.Text));
                shoppingCart.ItemsSource = null;
                DataContext = purchaseManager.shoppingCart;
                shoppingCart.ItemsSource = purchaseManager.shoppingCart;
                MessageBox.Show("Successfully added ! ");
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

        private void AddIntoTable(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(itemNumberTextBox.Text) && !string.IsNullOrEmpty(discountTextBox.Text))
            {
                clearError();
                purchaseManager.AddToCart(int.Parse(itemNumberTextBox.Text), float.Parse(discountTextBox.Text));
                shoppingCart.ItemsSource = null;
                DataContext = purchaseManager.shoppingCart;
                shoppingCart.ItemsSource = purchaseManager.shoppingCart;
                MessageBox.Show("Successfully added ! ");
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "* Fill all fields";
            }
        }

        private void makePurchase_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for purchasing !");
            purchaseManager.SavePurchase();
            shoppingCart.ItemsSource = null;
            discountTextBox.Clear();// to clear discount in order if you want to change it
        }

        
    }
}

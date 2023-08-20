using SimpleCashRegisterLibrary.Business;
using SimpleCashRegisterLibrary.Model;
using System;
using System.Collections;
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
using System.Xml.Linq;

namespace SimpleCashRegisterUI
{
    /// <summary>
    /// Logique d'interaction pour PurchaseUI.xaml
    /// </summary>
    public partial class PurchaseUI : Window
    {
        PurchaseManager purchaseManager=new PurchaseManager();
        ItemManager itemManager = new ItemManager();
        List<Shopping> shoppingList = new List<Shopping>();

        public PurchaseUI()
        {
            InitializeComponent();
            clearError();
        }

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           /* PurchaseManager c = new PurchaseManager();
            c.SavePurchase();*/
        }
    }
}

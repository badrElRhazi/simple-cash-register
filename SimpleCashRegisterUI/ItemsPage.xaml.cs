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
using System.Windows.Shapes;

namespace SimpleCashRegisterUI
{
    /// <summary>
    /// Logique d'interaction pour ItemsPage.xaml
    /// </summary>
    public partial class ItemsPage : Window
    {
        private ItemManager itemManager = new ItemManager();
        public ItemsPage()
        {
            InitializeComponent();
            clearError();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(itemNameTextBox.Text) && !string.IsNullOrEmpty(itemDescriptionTextBox.Text)
                && !string.IsNullOrEmpty(itemPriceTextBox.Text))
            {
                string name = itemNameTextBox.Text;
                string description = itemDescriptionTextBox.Text;
                float price = float.Parse(itemPriceTextBox.Text);

                itemManager.AddItem(name, description, price);

                itemNameTextBox.Clear();
                itemDescriptionTextBox.Clear();
                itemPriceTextBox.Clear();
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "* Fill all fields";
            }
        }

        

        private void StartPurchase_Click(object sender, RoutedEventArgs e)
        {
            PurchaseUI page = new PurchaseUI();
            this.Visibility = Visibility.Hidden;
            Application.Current.MainWindow.Visibility = Visibility.Hidden;
            page.Show();
        }
        public void clearError()
        {
            ErrorLabel.Visibility = Visibility.Hidden;
        }
    }
}

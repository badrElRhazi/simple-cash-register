using SimpleCashRegisterLibrary.Business;
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
    /// Logique d'interaction pour Artikl.xaml
    /// </summary>
    public partial class Artikl : UserControl
    {
        private MainWindow mainw;
        public Artikl()
        {
            InitializeComponent();
            clearError();
        }
        private ItemManager itemManager = new ItemManager();
        

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
                clearError();
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
    }
}


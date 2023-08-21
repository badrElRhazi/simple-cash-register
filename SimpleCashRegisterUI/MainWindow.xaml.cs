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
using SimpleCashRegisterLibrary.Business;
using SimpleCashRegisterLibrary.Model;

namespace SimpleCashRegisterUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CashierManager cashierManager = new CashierManager();

        public MainWindow()
        {
            
            InitializeComponent();
            Login loginControl = new Login(this);
            CC.Content = loginControl;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                ListViewItem selectedItem = e.AddedItems[0] as ListViewItem;

                if (selectedItem != null)
                {
                    string itemText = ((TextBlock)((StackPanel)selectedItem.Content).Children[1]).Text;

                     if (itemText == "Purchase") // unable to code it the same way as i did for Artikl that's why.
                    {
                        CC.Content = new PurchaseAdd();
                    }
                }
            }
        }
    }
}

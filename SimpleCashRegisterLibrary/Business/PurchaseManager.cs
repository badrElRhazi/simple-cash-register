using SimpleCashRegisterLibrary.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Business
{
    public class PurchaseManager
    {
        public List<Shopping> shoppingCart;
        private FileManager _fileManager;
        List<Purchase> purchaseList = new List<Purchase>(); 
        private readonly static string FILE_NAME = "purchase.txt";

        public PurchaseManager()
        {
            shoppingCart = new List<Shopping>();
            _fileManager = new FileManager();

        }

        public void StartPurchase()
        {
            shoppingCart.Clear();
        }

        public List<Item> LoadItems()
        {
            return _fileManager.LoadItems("items.txt");
        }

        public void AddToCart(int itemNumber, double discount)
        {
            bool exist = false;
            ItemManager itemManager = new ItemManager();
            foreach (Item item in itemManager.itemList)
            {
                if (item.ItemNumber == itemNumber)
                {

                    item.Price = (float)ApplyDiscount(item.Price, discount);
                    foreach (Shopping i in shoppingCart)
                    {
                        if (i.ItemNumber == itemNumber)
                        {
                            i.Quantity = i.Quantity + 1;
                            i.Discount = (float)discount;
                            i.Price += item.Price;
                            i.Price=Math.Round(i.Price, 2);
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        Shopping shoppingItem = new Shopping
                        {
                            ItemNumber = itemNumber,
                            Quantity = 1,
                            Discount = (float)discount,
                            Price=Math.Round(item.Price, 2)
                            
                    };
                        shoppingCart.Add(shoppingItem);
                    }
                }
            }
        }

        public double ApplyDiscount(double price,double discountPercent)
        {
            price-=price*discountPercent/100;
            price= Math.Round(price,2);
            return (double)price;
        }
        public void SavePurchase()
        {
            using (StreamWriter writer = new StreamWriter(FILE_NAME, true)) 
            {
                writer.WriteLine("** NEW PURCHASE : ItemNumber | Quantity | Discount | Price");
                foreach (Shopping item in shoppingCart)
                {
                    string purchaseInfo = $"{item.ItemNumber},{item.Quantity},{item.Discount},{item.Price}";
                    writer.WriteLine(purchaseInfo);
                }
            }
        }

    }
}

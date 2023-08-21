using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Model
{
    public class Purchase:Shopping
    {
        private int _purchaseID=0;
        private DateTime _purchaseDate;
        private List<Item> _purchasedItems= new List<Item>();
        private float _totalAmount;

        public Purchase()
        {
            PurchaseDate = DateTime.Now;
            PurchasedItems = new List<Item>();
        }
        public Purchase(int purchaseID, DateTime purchaseDate, List<Item> purchasedItems)
        {
            PurchaseID = purchaseID;
            PurchaseDate = purchaseDate;
            PurchasedItems = purchasedItems;
        }
        public Purchase(int itemNumber, int quantity, double discount, double price)
        {
            ItemNumber = itemNumber;
            Quantity = quantity;
            Discount = (float)discount;
            Price = price;
        }
        public int PurchaseID { get => _purchaseID; set => _purchaseID = value; }
        public DateTime PurchaseDate { get => _purchaseDate; set => _purchaseDate = value; }
        public float TotalAmount { get => _totalAmount; set => _totalAmount = value; }
        internal List<Item> PurchasedItems { get => _purchasedItems; set => _purchasedItems = value; }
    }
}

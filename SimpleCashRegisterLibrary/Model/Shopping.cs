using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Model
{
    public class Shopping
    {
        public int Quantity { get; set; }
        public int ItemNumber { get; set; }
        public double Price { get; set; }
        public float Discount { get; set; }
        
        public Shopping() { }

        public Shopping(int quantity, int itemNumber,  float discount, double price)
        {
            Quantity = quantity;
            ItemNumber = itemNumber;
            Discount = discount;
            Price = price;
        }

    }
}

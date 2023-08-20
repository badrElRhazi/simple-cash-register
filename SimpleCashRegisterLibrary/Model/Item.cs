using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Model
{
    public class Item
    {
        private int _idItem;
        private string _name;
        private string _description;
        private float _price;
        private int _itemNumber;

        public Item(int idItem)

        {
            IdItem = idItem;
            
        }

        public Item(int idItem, string name, string description, float price, int itemNumber)

        {
            IdItem = idItem;
            Name = name;
            Description = description;
            Price = price;
            ItemNumber = itemNumber;
        }

        public int IdItem { get => _idItem; set => _idItem = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public float Price { get => _price; set => _price = value; }
        public int ItemNumber { get => _itemNumber; set => _itemNumber = value; }

        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   _idItem == item._idItem &&
                   _name == item._name &&
                   _description == item._description &&
                   _price == item._price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_idItem, _name, _description, _price);
        }
    }
}

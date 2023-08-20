using SimpleCashRegisterLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleCashRegisterLibrary.Business
{
    public class ItemManager
    {
        private FileManager _fileManager;
        private readonly static string FILE_NAME = "items.txt";
        public List<Item> itemList = new List<Item>();

        public ItemManager()
        {
            _fileManager = new FileManager();
            itemList = _fileManager.LoadItems(FILE_NAME);
        }

        public void AddItem(string name, string description, float price)
        {
            if (itemList.Find((Item) => Item.Name == name) != null)
            {
                return;
            }
            
            int nextItemId = itemList.Count + 1;
            Item newItem = new Item(nextItemId)
            {
                Name = name,
                Description = description,
                Price = price,
                ItemNumber = generateCodeBar()
            };
            itemList.Add(newItem);
            _fileManager.SaveItems(itemList, "items.txt");
        }

        public int generateCodeBar()
        {
            var rndm = new Random();
            int CodeBar = ((int)rndm.Next(100000, 999999));
            while (itemList.Find((Item) => Item.ItemNumber == CodeBar) != null)
            {
                rndm.Next(100000, 999999);
            }
            return CodeBar;
        }
    }
}

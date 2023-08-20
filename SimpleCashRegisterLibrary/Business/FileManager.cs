using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SimpleCashRegisterLibrary.Model;

namespace SimpleCashRegisterLibrary.Business
{
    internal class FileManager
    {
        public void SaveCashiers(List<Cashier> cashiers, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Cashier cashier in cashiers)
                {
                    writer.WriteLine($"{cashier.Id},{cashier.Login},{cashier.Password}");
                }
            }
        }

        public List<Cashier> LoadCashiers(string fileName)
        {
            List<Cashier> cashiers = new List<Cashier>();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            int id = int.Parse(parts[0]);
                            string login = parts[1];
                            string password = parts[2];
                            cashiers.Add(new Cashier(id, login, password));
                        }
                    }

                }
            }

            return cashiers;
        }
        public int FileLine(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadLines(fileName).Count();
            }
            return 0;
        }
        public void SaveItems(List<Item> items, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Id Item | Name | Description | Price | ItemNumber");
                foreach (Item item in items)
                {
                    writer.WriteLine($"{item.IdItem},{item.Name},{item.Description},{item.Price},{item.ItemNumber}");
                }
            }
        }

        public List<Item> LoadItems(string fileName)
        {
            List<Item> items = new List<Item>();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 5)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string description = parts[2];

                            if (float.TryParse(parts[3], out float price)) 
                            {
                                int itemNumber = int.Parse(parts[4]);
                                items.Add(new Item(id, name, description, price, itemNumber));
                            }
                            else
                            {
                                Console.WriteLine($"Invalid price value: {parts[3]}");
                            }
                        }
                    }

                }
            }
            return items;
        }
        


    }
}

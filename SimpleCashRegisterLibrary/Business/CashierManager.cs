using SimpleCashRegisterLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Business
{
    public class CashierManager
    {
        private FileManager _fileManager;
        private readonly static string FILE_NAME = "cashiers.txt";
        List<Cashier> cashierList = new List<Cashier>();

        public CashierManager()
        {
            _fileManager = new FileManager();
            cashierList = _fileManager.LoadCashiers(FILE_NAME);
        }

         public void  addCashier(string username,string password)
            {
            if (cashierList.Find((c) => c.Login == username) != null)
            {
                return;
            }

                int nextCashierId = cashierList.Count + 1;
                Cashier newCashier = new Cashier(nextCashierId)
                {
                    Login = username,
                    Password = password
                };
                cashierList.Add(newCashier);
                _fileManager.SaveCashiers(cashierList, FILE_NAME);
            }
        public bool Login(string username, string password)
        {
           if (Count() != 0)
            {
                if (cashierList.Find((c) => c.Login == username && c.Password == password) != null)
                {
                    return true;
                }
            }
            else
            {
                addCashier(username, password);
                return true;
            }
            return false;
        }
        public int Count()
        {
            return _fileManager.FileLine("cashiers.txt");
        }

    }
}

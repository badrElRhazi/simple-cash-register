using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashRegisterLibrary.Model
{
    public class Cashier
    {
        private int _id;
        private string _login;
        private string _password;
        
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        public Cashier(int id)
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        {
            Id = id;
        } 
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
            public Cashier(int id, string login, string password)
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        {
            Id = id;
            Login = login;
            Password = password;
        }
        

        public int Id { get => _id; set => _id = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        public override bool Equals(object? obj)
        {
            return obj is Cashier cashier &&
                   _id == cashier._id &&
                   _login == cashier._login &&
                   _password == cashier._password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _login, _password);
        }
    }
}

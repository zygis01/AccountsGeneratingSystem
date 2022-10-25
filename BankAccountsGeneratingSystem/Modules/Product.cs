using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Modules
{
    internal class Product
    {
        public int iD;
        public string name;
        public double price;
        public Product(int Id, string Name, double Price)
        {
            iD = Id;
            name = Name;
            price = Price;
        }
    }
}

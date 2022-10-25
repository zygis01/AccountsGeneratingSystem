using BankAccountsGeneratingSystem.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Repositories
{
    internal class ProductsRepository
    {
        List<Product> products = new List<Product>();
        public ProductsRepository()
        {
            products.Add(new Product(100, "Computer part", 89.99));
            products.Add(new Product(101, "Slippers", 12.00));
            products.Add(new Product(102, "T-Shirt", 4.49));
            products.Add(new Product(103, "Old chest", 189.99));
            products.Add(new Product(104, "Rotten egg", 1.99));
            products.Add(new Product(105, "Black piano", 650.99));
            products.Add(new Product(106, "Motorcycle toy", 28.29));
            products.Add(new Product(107, "Barbie toy", 18.69));
            products.Add(new Product(108, "Number plate", 21.89));
            products.Add(new Product(109, "Fake Drivers License", 410.99));
            products.Add(new Product(110, "LED lamp", 50.99));
            products.Add(new Product(111, "Bluetooth mouse", 40.89));
            products.Add(new Product(112, "Full size speakers", 109.79));
        }
        public List<Product> RetrieveList()
        {
            return products;
        }
        public Product RetrieveBy(int id)
        {
            var xRepository = products[0];
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].iD == id)
                {
                    xRepository = products[i];
                }
            }
            return xRepository;
        }
    }
}

using BankAccountsGeneratingSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Modules
{
    internal class ReportItem
    {
        public int productId1 { get; set; }
        public int productId2 { get; set; }
        public int productId3 { get; set; }
        public string productName1 { get; set; }
        public string productName2 { get; set; }
        public string productName3 { get; set; }
        public double productPrice1 { get; set; }
        public double productPrice2 { get; set; }
        public double productPrice3 { get; set; }
        public int product1Amount { get; set; }
        public int product2Amount { get; set; }
        public int product3Amount { get; set; }
        public ReportItem()
        {
            AccountsRepository accRepository = new();
            ProductsRepository productsRepository = new();

            var accList = accRepository.RetrieveList();
            foreach (var account in accList)
            {
                productId1 = account.product1Id;
                productId2 = account.product2Id;
                productId3 = account.product3Id;
                productName1 = productsRepository.RetrieveBy(account.product1Id).name;
                productName2 = productsRepository.RetrieveBy(account.product2Id).name;
                productName3 = productsRepository.RetrieveBy(account.product3Id).name;
                productPrice1 = productsRepository.RetrieveBy(account.product1Id).price;
                productPrice2 = productsRepository.RetrieveBy(account.product2Id).price;
                productPrice3 = productsRepository.RetrieveBy(account.product3Id).price;
                product1Amount = account.product1Amount;
                product2Amount = account.product2Amount;
                product3Amount = account.product3Amount;
            }
        }
    }
    
    
}

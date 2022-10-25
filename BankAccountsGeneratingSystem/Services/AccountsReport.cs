using BankAccountsGeneratingSystem.Modules;
using BankAccountsGeneratingSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Services
{
    internal class AccountsReport
    {
        AccountsRepository accountsRepository = new AccountsRepository();
        ReportItem reportItem = new ReportItem();

        public void ReportAccountsList()
        {
            var accList = accountsRepository.RetrieveList();
            foreach (var account in accList)
            {

                Console.WriteLine("Information about account: ");
                Console.Write("|" + account.accName);
                Console.Write(account.accNumber + "|\n");
                Console.WriteLine(account.accProviderName);
                Console.WriteLine();
                Console.WriteLine("Items bought: ");
                Console.WriteLine($"Product ID : {reportItem.productId1} - {reportItem.productName1} ${reportItem.productPrice1} x {account.product1Amount}");
                Console.WriteLine($"Product ID : {reportItem.productId2} - {reportItem.productName2} ${reportItem.productPrice2} x {account.product2Amount}");
                Console.WriteLine($"Product ID : {reportItem.productId3} - {reportItem.productName3} ${reportItem.productPrice3} x {account.product3Amount}");
                var totalSum = (account.product1Amount * reportItem.productPrice1) + 
                               (account.product2Amount * reportItem.productPrice2) + 
                               (account.product3Amount * reportItem.productPrice3);
                Console.WriteLine($"Total cost: {Math.Round(totalSum, 2)}$");
                Console.WriteLine();
            }
        }

    }
}

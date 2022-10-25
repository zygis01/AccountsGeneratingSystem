using BankAccountsGeneratingSystem.Modules;
using BankAccountsGeneratingSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Services
{
    internal class StartSystem
    {
        AccountsRepository accRepository = new AccountsRepository();
        AccountsReport accReport = new AccountsReport();
        ReportItem reportItem = new ReportItem();

        public void StartTheSystem()
        {
            var accList = accRepository.RetrieveList();

            Console.WriteLine("Full list of accounts : ");
            Console.WriteLine("______________________");
            foreach (var account in accList)
            {
                var amount = account.product1Amount + account.product2Amount + account.product3Amount;

                Console.WriteLine(account.accName + account.accNumber);
                Console.WriteLine(account.accProviderName);
                Console.WriteLine($"Account has {amount}x of products");
                Console.WriteLine("______________________");
            }
            var xAmount1 = accList.Sum(x => x.product1Amount);
            var xAmount2 = accList.Sum(x => x.product2Amount);
            var xAmount3 = accList.Sum(x => x.product3Amount);
            var sum = xAmount1 + xAmount2 + xAmount3;

            Console.WriteLine($"Sum of all products : {sum}");

            bool play = true;
            while (play)
            {
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                var readInput = Console.ReadLine();
                if (readInput == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Information for all of the accounts or individual? (all/ind)");
                    var readSecondInput = Console.ReadLine();
                    if (readSecondInput == "all")
                    {
                        Console.Clear();
                        accReport.ReportAccountsList();
                    }
                    else if (readSecondInput == "ind")
                    {
                        Console.WriteLine("Which account 1-6? :");
                        Console.WriteLine("LT [1]");
                        Console.WriteLine("FRA [2]");
                        Console.WriteLine("ITA [3]");
                        Console.WriteLine("LV [4]");
                        Console.WriteLine("PL [5]");
                        Console.WriteLine("AE [6]");
                        string readData = Console.ReadLine();
                        int inputInt;
                        bool success = int.TryParse(readData, out inputInt);

                        if (success == true && inputInt >= 1 && inputInt <= 6)
                        {
                            var find = accList.Find(x => x.iD == Convert.ToInt32(readData));
                            var totalSum = (find.product1Amount * reportItem.productPrice1) +
                                           (find.product2Amount * reportItem.productPrice2) +
                                           (find.product3Amount * reportItem.productPrice3);

                            Console.Clear();

                            Console.WriteLine(find.accName + find.accNumber);
                            Console.WriteLine(find.accProviderName);
                            Console.WriteLine();
                            Console.WriteLine("Items bought: ");
                            Console.WriteLine($"Product ID : {find.product1Id} - {reportItem.productName1} ${reportItem.productPrice1} x {find.product1Amount}");
                            Console.WriteLine($"Product ID : {find.product2Id} - {reportItem.productName2} ${reportItem.productPrice2} x {find.product2Amount}");
                            Console.WriteLine($"Product ID : {find.product3Id} - {reportItem.productName3} ${reportItem.productPrice3} x {find.product3Amount}");
                            Console.WriteLine($"Total cost: {Math.Round(totalSum, 2)}$");
                            Console.WriteLine();
                        }                                    
                        else                                 
                        {
                            Console.WriteLine("Wrong input, input number between 1 and 6! : ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose between (all/ind)! : ");
                        Console.WriteLine();
                    }
                    Console.WriteLine("|-|BANK ACCOUNTS SYSTEM|-|");
                    Console.WriteLine();
                }
                else if (readInput == "n")
                {
                    Console.WriteLine("Closing the program...");
                    play = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Choose between (y/n)! : ");
                }
            }
        }
        public void WriteInfoToTxtFile(string accountsData)
        {
            var accList = accRepository.RetrieveList();
            File.WriteAllText(accountsData, "");
            
            foreach (var account in accList)
            {
                var totalSumOfProducts = (account.product1Amount * reportItem.productPrice1) +
                               (account.product2Amount * reportItem.productPrice2) +
                               (account.product3Amount * reportItem.productPrice3);
                var roundedTotalSumOfProducts = Math.Round(totalSumOfProducts, 2);
                account.accountBalanceAfterPurchases = account.accountBalance - roundedTotalSumOfProducts;

                File.AppendAllText(accountsData, $"{"[---------------------------------------------------]\n"}" +
                                                 $"{account.accName}{account.accNumber}\n" +
                                                 $"{account.accProviderName}\n" +
                                                 $"Account balance: ${account.accountBalance}\n" +
                                                 $"Account balance after purchases: ${account.accountBalanceAfterPurchases}\n" +
                                                 $"{"\n"}" +
                                                 $"Items bought: \n" +
                                                 $"Product ID : {account.product1Id} - {reportItem.productName1} ${reportItem.productPrice1} x {account.product1Amount}\n" +
                                                 $"Product ID : {account.product2Id} - {reportItem.productName2} ${reportItem.productPrice2} x {account.product2Amount}\n" +
                                                 $"Product ID : {account.product3Id} - {reportItem.productName3} ${reportItem.productPrice3} x {account.product3Amount}\n" +
                                                 $"Total cost: ${roundedTotalSumOfProducts}\n" +
                                                 $"{"\n"}");
            }
        }
    }
}

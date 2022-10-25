using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Modules
{
    public class Account
    {
        public string accName;
        public int iD;
        public double accNumber;
        public string accProviderName;
        public int product1Id;
        public int product2Id;
        public int product3Id;
        public int product1Amount;
        public int product2Amount;
        public int product3Amount;
        public double accountBalance;
        public double accountBalanceAfterPurchases;

        public Account(string AccName, int Id, double AccNumber, string AccProviderName, int Product1Id, int Product2Id, int Product3Id, int Product1Amount, int Product2Amount, int Product3Amount, double AccountBalance)
        {
            accName = AccName;
            iD = Id;
            accNumber = AccNumber;
            accProviderName = AccProviderName;
            product1Id = Product1Id;
            product2Id = Product2Id;
            product3Id = Product3Id;
            product1Amount = Product1Amount;
            product2Amount = Product2Amount;
            product3Amount = Product3Amount;
            accountBalance = AccountBalance;
        }
        public Account()
        {

        }
    }
}

using BankAccountsGeneratingSystem.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsGeneratingSystem.Repositories
{
    public class AccountsRepository
    {
        public List<Account> accounts = new List<Account>();

        public AccountsRepository()
        {
            accounts.Add(new Account("LT", 1, 5123817238121, "Swedbank", 100, 111, 106, 4, 7, 4, 2000));
            accounts.Add(new Account("FRA", 2, 8129381239992, "BNP Paribas", 102, 110, 104, 3, 3, 9, 2000));
            accounts.Add(new Account("ITA", 3, 1231782398172, "UniCredit", 101, 109, 107, 8, 3, 4, 2000));
            accounts.Add(new Account("LV", 4, 1092312312381, "BluOr Bank", 112, 105, 103, 5, 3, 7, 2000));
            accounts.Add(new Account("PL", 5, 1238127381273, "Santander", 107, 110, 108, 1, 9, 5, 2000));
            accounts.Add(new Account("AE", 6, 2347817283123, "Mashreq Neo", 112, 111, 110, 5, 5, 5, 2000));
        }
        public List<Account> RetrieveList()
        {
            return accounts;
        }
        public Account RetrieveBy(int accountId)
        {
            var xRepository = accounts[0];
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].iD == accountId)
                {
                    xRepository = accounts[i];
                }
            }
            return xRepository;
        }
    }
}

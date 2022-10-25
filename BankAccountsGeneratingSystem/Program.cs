using BankAccountsGeneratingSystem.Modules;
using BankAccountsGeneratingSystem.Repositories;
using BankAccountsGeneratingSystem.Services;
using System.Security.Principal;

StartSystem system = new StartSystem();
system.StartTheSystem();
string accountsData = "C:\\Users\\Zygimantas\\source\\repos\\BankAccountsGeneratingSystem\\BankAccountsGeneratingSystem\\TextData\\AccountsData.txt";
system.WriteInfoToTxtFile(accountsData);

Console.WriteLine("|-|BANK ACCOUNTS SYSTEM|-|");
Console.WriteLine();









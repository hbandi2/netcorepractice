using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Test User", 2000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "purchase1");

            account.MakeWithdrawal(500, DateTime.Now, "purchase2");

            account.MakeDeposit(700, DateTime.Now, "deposit1");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}

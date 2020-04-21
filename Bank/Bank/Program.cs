using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tobias", 2000);
            Console.WriteLine($"Konto {account.Number} blev oprettet til {account.Owner} med {account.Balance}. ");

            account.MakeWithdrawal(200, DateTime.Now, "Stol");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(1200, DateTime.Now, "TV");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        


        }
    }
}

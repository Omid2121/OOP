using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BankAccount
    {

        public string  Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount (string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException("Withdrawal must be positive");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

        public  string GetAccountHistory()
        {
            var reprot = new StringBuilder();

            reprot.AppendLine($"Date \t \t Amount \t Note");

            foreach (var item in allTransactions)
            {
                reprot.AppendLine($"{item.Date.ToShortDateString()} \t {item.Amount} \t {item.Notes}");
            }
            return reprot.ToString();



        }


    }
}

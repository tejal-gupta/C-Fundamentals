using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Program_6__MySuperBank
{
    public class BankAccount
    {
        public string Number { get; } //Using prop and tab
        public string Owner  { get; set; }
        public decimal Balance {   
            get
            {
                decimal balance = 0;
                foreach ( var item in allTransactions)
                {
                    balance += item.Amount;  //balance is calculated by summing all transactions
                }
                return balance; //thus returning current balance value
            }
             }

        //This is private, so it is used only in this class. Not visible outside
        //also, since it is static, it is being shared around all bank accounts as seed
        private static int accountNumberSeed = 1234567890;

        //List of transactions
        private List<Transaction> allTransactions = new List<Transaction>();

        //Constructor
        /**At first we initialized constructor with two arguments: name and initialBalance. But after creating a 
        a getter for the class BankAccount, we remove it. We already set the balance in the getter to 0
        so, we dont set any initial balance, we dont want to give money away to people.
        For this, they need to make a deposit**/
        public BankAccount(string name, decimal initialBalance) 
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }
        public void MakeDeposit(decimal amount, DateTime date, string note)//To make deposit
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)//To make withdrawal
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            
            //HEADER
            report.AppendLine("Date\t\tAmount\t\tNote");
            foreach (var item in allTransactions)
            {
                //ROW
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}

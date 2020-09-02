﻿using System;

namespace Program_6__MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Tejal",10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");

            account.MakeWithdrawal(100, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            /**account.MakeDeposit(-300, DateTime.Now, "Stealing");
             throws exception**/
            //TEST FOR CATCHING EXCEPTIONS
            // Test that the initial balances must be positive.
            /**try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            **/
            

        }
    }
}

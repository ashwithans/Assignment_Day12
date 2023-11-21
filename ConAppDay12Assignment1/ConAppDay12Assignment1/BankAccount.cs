using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay12Assignment1
{
    public class BankAccount
    {
        private static int accountNumber = 1234;

        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        public BankAccount(string accountHolderName)
        {
            AccountNumber = accountNumber++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount}. Current Balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}. Current Balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine($"\nAccount Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance}");
        }
    }
}

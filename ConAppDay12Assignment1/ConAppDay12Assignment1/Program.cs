using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay12Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            BankAccount account = new BankAccount(name);

            Console.Write("Enter deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(depositAmount);

            Console.Write("Enter withdrawal amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(withdrawalAmount);

            account.PrintAccountDetails();
            Console.ReadKey();
        }
    }
}

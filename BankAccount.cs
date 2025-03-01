using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class BankAccount
    {
        private decimal balance;
        public decimal Balance { get { return balance; } }

        public BankAccount(decimal balance )
        {
            if (balance<0)
            {
                Console.WriteLine("Balans menfi ola bilmez!");
                balance = 0;
            }
            else
                this.balance = balance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Mebleg musbet olmalidir.");
            }
            else
            {
                if (balance < amount)
                {
                    Console.WriteLine("Balansda movcud mebleg yoxdur!");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"{amount} AZN mebleg balansdan cixarildi. Balans: {balance}");
                }
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balans: {balance}");
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} AZN balansa elave edildi. Balans: {balance}");
            }
            else
                Console.WriteLine("Mebleg menfi ya 0 ola bilmez");
        }
    }
}

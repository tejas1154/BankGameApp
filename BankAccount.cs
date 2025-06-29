using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountGame
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public double Balance { get; set; }

        public BankAccount(string holder, double balance)
        {
            AccountHolder = holder;
            Balance = (balance > 0) ? balance : 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{AccountHolder} deposited {amount}. New Balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if(amount >= Balance)
            {
                Console.WriteLine("Insufficient balance. Withdraw deined");
                return;
            }

            Balance -= amount; ;
            Console.WriteLine($"{AccountHolder} withdraw {amount}. New Balance: {Balance}");
        }
    }
}

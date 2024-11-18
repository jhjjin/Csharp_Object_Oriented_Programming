using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_2
{
    class Saving:BankAccount
    {
        public Saving(string accountNum, string owerName, double balance):base(accountNum, owerName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if(amount>balance)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }
            balance -= amount;
            Console.WriteLine("{0} amount withdrawn. New balance: {1} ", amount, balance);
        }
        public override void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine("{0} amount deposited. New balance: {1}", amount, balance);
        }
        public override void ToString()
        {
            Console.WriteLine("Account Number: {0} Ower Name: {1} Balance: {2}", accountNumber, ownerName, balance);
        }
        ~Saving() { }
    }
}

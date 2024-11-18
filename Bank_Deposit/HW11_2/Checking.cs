using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_2
{
    class Checking:BankAccount
    {
        public Checking(string accountNum, string ownerNm, double bal) : base(accountNum, ownerNm, bal)
        {

        }
        public override void Withdraw(double amount)
        {
            if(amount > balance)
            {
                Console.WriteLine("Invalid Number");
                return;
            }
            balance -= amount;
            Console.WriteLine("{0} amount withdrawn. New balance is {1}", amount, balance);
        }
        public override void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine("{0} amount deposited. New balance is {1}", amount, balance);
        }
        public override void ToString()
        {
            Console.WriteLine("Account Number: {0} Ower Name: {1} Balance: {2}", accountNumber, ownerName, balance);
        }
        ~Checking() { }
    }
}

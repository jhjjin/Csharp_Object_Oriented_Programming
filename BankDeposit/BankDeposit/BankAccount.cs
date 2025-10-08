using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_2
{
    class BankAccount
    {
        protected string accountNumber;
        protected string ownerName;
        protected double balance;

        public BankAccount()
        {
            accountNumber = "unknown";
            ownerName = "unknown";
            balance = 0;
        }

        public BankAccount(string accountNum, string ownerNm, double bal)
        {
            accountNumber = accountNum;
            ownerName = ownerNm;
            balance = bal;
        }
        public double Balance
        {
            get { return balance; }
            set{ balance = value; }
        }
        public virtual void Withdraw(double amount)
        {
            
        }
        public virtual void Deposite(double amount)
        {
            
        }
        public virtual void ToString()
        {
            Console.WriteLine("Account Number: {0} Ower Name: {1} Balance: {2}", accountNumber, ownerName, balance);
        }
        ~BankAccount() { }
    }
}

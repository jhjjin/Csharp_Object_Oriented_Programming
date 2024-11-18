using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking("1001", "Hyukjin", 1000);
            Console.WriteLine("Checking Account: ");
            checking.ToString();

            checking.Deposite(400);
            checking.Withdraw(200);


            Saving saving = new Saving("4939", "Jeong", 3000);
            Console.WriteLine("Savings Account: ");
            saving.ToString();

            saving.Deposite(400);
            saving.Withdraw(200);

            Console.Read();

        }
    }
}

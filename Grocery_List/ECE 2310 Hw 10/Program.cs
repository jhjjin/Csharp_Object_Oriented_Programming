using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Hw_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk(4.75, 1);
            Bread bread = new Bread(2.50, 2);
            Eggs eggs = new Eggs(4.00, 3);
            Grocery obj = new Grocery(milk, bread, eggs);

               
            Console.WriteLine(obj);

            Console.Read();
        }
    }
}

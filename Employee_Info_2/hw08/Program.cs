using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Hyukjin", "Jeong", 101, 5000.0);
            Employee employee2 = new Employee("James", "K", 102, 4000.0);

            Console.Write("Employee 1: ");
            employee1.DisplayInfo();
            Console.Write("\nEmployee 2: ");
            employee2.DisplayInfo();

            
            Console.Read();

        }
    }
}

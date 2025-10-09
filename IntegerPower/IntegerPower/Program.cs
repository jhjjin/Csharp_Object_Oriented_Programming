using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPower
{
    internal class Program
    {
        // 2-A) 
        /*static void Main(string[] args)
        {
            Console.WriteLine("The result of 3^4 is " + IntegerPower(3, 4));
            Console.Read();
        }

        static int IntegerPower(int baseNum, int exponent)
        {
            int result = 1;
            for(int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }*/
        //2-B)
        static void Main(string[] args)
        {
            int sum = 0; 
            sum += IntegerPower(2, 10);
            
            Console.WriteLine("The result value of 2^10 is {0}", sum);
            Console.Read();
        }
        static int IntegerPower(int baseNum, int exponent)
        {
            int result = 1; 
            for(int i =0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }

    }
}

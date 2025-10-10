using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] k = new int[10];
            for (int j =0; j < 10; j++)
            {
                k[j] = j + 1;

            }
            PrintArray(k);
            Console.Read();
        }
        static void PrintArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(" Index : {0}\t Element : {1}", i, x[i]);
            
        }
    }
}

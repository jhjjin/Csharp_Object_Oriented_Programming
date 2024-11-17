using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_19_ECE2310
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] k = new int[100];
            for (int j =0; j < 100; j++)
            {
                k[j] = j + 1;
                Console.WriteLine("element with index of {0}:   {1}", j,k[j]);
            }
            SumArray(k);    
            int a = 3, b = 10;
            Test(ref a, ref b);
            //int c = Test(a, ref b);
            Console.WriteLine(" a = {0},     b = {1}", a,b);

            // call PrintSum to display the sum of 1+2+...+100
            PrintSum(100);

            Console.Read();
        }

        static int Test(int m, ref int n)
        {
            n = m + n;
            return m * m;
        }

        static void Test(ref int m, ref int n) // Pass by reference 
        {
            n += m;
            m *= m;
        }

        static void SumArray(int[] x)
        {
            int y = 0; 
            for(int i =0; i< x.Length; i++) 
                y += x[i];
            Console.WriteLine("The sum of all the elements of the array is {0}", y);

        }

        static void PrintSum(int n)
        {
            int sum = 0;
            for (int i = 0; i< n +1; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is {0}" , sum);
            
        }
        
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("The area of triangle is {0}", AreaOfTriangle(2.2, 3.3, 4.4));
            Console.Read();
            
        }
        static double AreaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) /2;
            double areaS = Math.Sqrt((s) * (s - a) * (s - b) * (s - c));
            return areaS;
            
        }


        /*static void Main(string[] args)
        {
          
            Console.WriteLine("The value of distance is {0}", Distance2(2.3, 4.3, 2.3, 4.5));

            Console.Read();
        }
        static double Distance2(double x1, double x2, double y1, double y2)
        {

            double distance = Math.Sqrt((Math.Abs((x1 - x2) * (x1 - x2))) + (Math.Abs((y1 - y2) * (y1 - y2))));
            return distance;
        }*/
    }
}

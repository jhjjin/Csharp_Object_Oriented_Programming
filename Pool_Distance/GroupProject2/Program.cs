using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The pool count is " + Pool.Count);

            Location[] loc = new Location[8];
            List<(double,double)>pools = new List<(double, double)> { (0,0),(1,3),(4,2),(4,8),(6,6),(10,5),(12,9),(13,1) };
            List<string> poolNames = new List<string> { "Strat", "B", "C", "A", "G", "F", "E", "D" };

            Random random = new Random();

            for(int i =0; i<8; i++)
            {
                double temperature = random.Next(98, 105);
                Temperature temp = new Temperature(temperature, "farenheit,");
                Pool pool = new Pool(temp, loc[i]);
                Console.WriteLine("The pool count is " + Pool.Count + temp + "Location " + pools[i] + poolNames[i]);
            }

            double d0, d1, d2, d3, d4, d5, d6, d7, d8; 
            d0 = Pool.FindDistance(0, 0, 1, 3); 
            d1 = Pool.FindDistance(0, 0, 4, 2); 
            var V = Utility.Lesser(d0, d1); 
            Console.WriteLine($"\nfrom cordinates {pools[0]} {poolNames[0]} point"); 
            Console.WriteLine($"{poolNames[1]} is {d0:F2} miles away, {poolNames[2]} is {d1:F2} miles away.\n The Closes pool is {V:F2}"); 
            
            d2 = Pool.FindDistance(1, 3, 4, 8); 
            d3 = Pool.FindDistance(1, 3, 6, 6); 
            d4 = Pool.FindDistance(1, 3, 4, 2); 
            var V2 = Utility.Lesser2(d2, d3, d4); 
            Console.WriteLine($"\nfrom cordinates{pools[1]} pool {poolNames[1]}"); 
            Console.WriteLine($"Pool {poolNames[3]} is {d2:F2} miles away, pool {poolNames[4]} is {d3:F2} miles away,pool {poolNames[2]} is {d4:F2} miles away.\n The Closes pool is {V2:F2} miles"); 
            d5 = Pool.FindDistance(4, 2, 4, 8); 
            d6 = Pool.FindDistance(4, 2, 6, 6); 
            d7 = Pool.FindDistance(4, 2, 10, 5); 
            d8 = Pool.FindDistance(4, 2, 13, 1); 
            var V3 = Utility.Lesser3(d5, d6, d7, d8); 
            Console.WriteLine($"\nFrom cordinates {pools[2]} pool {poolNames[2]}"); 
            Console.WriteLine($"pool {poolNames[3]} is {d5:F2} miles away, pool {poolNames[4]} is {d6:F2} miles away,pool {poolNames[5]} is {d7:F2} miles away,pool {poolNames[7]} is {d8:F2} miles away.\n the closes pool is {V3:F2} miles");

            d5 = Pool.FindDistance(6, 6, 4, 8); 
            d6 = Pool.FindDistance(6, 6, 12, 9); 
            d7 = Pool.FindDistance(6, 6, 10, 5); 
            d8 = Pool.FindDistance(6, 6, 13, 1); 
            var V4 = Utility.Lesser3(d5, d6, d7, d8); 
            Console.WriteLine($"\nFrom cordinates {pools[4]} pool {poolNames[4]} "); 
            Console.WriteLine($"pool {poolNames[3]} is {d5:F2} miles away, pool {poolNames[6]} is {d6:F2} miles away,pool {poolNames[5]} is {d7:F2} miles away,pool {poolNames[7]} is {d8:F2} miles away.\n the closes pool is {V4:F2} miles"); 
            
            d6 = Pool.FindDistance(4, 8, 12, 9); 
            d7 = Pool.FindDistance(4, 8, 10, 5); 
            d8 = Pool.FindDistance(4, 8, 13, 1); 
            var V5 = Utility.Lesser2(d6, d7, d8); 
            Console.WriteLine($"\nFrom cordinates {pools[3]} pool {poolNames[3]}"); 
            Console.WriteLine($"pool {poolNames[6]} is {d6:F2} miles away, pool {poolNames[5]} is {d7:F2} miles away,pool {poolNames[7]} is {d8:F2} miles away.\n the closes pool is {V5:F2} miles"); 
            
            d0 = Pool.FindDistance(10, 5, 12, 9); 
            d1 = Pool.FindDistance(10, 5, 13, 1); 
            var V6 = Utility.Lesser(d0, d1); 
            Console.WriteLine($"\nFrom cordinates {pools[5]} pool {poolNames[5]} "); 
            Console.WriteLine($"Pool {poolNames[6]} is {d0:F2} miles away, pool {poolNames[7]} is {d1:F2} miles away.\n The Closes pool is {V6:F2} miles"); 
            
            d1 = Pool.FindDistance(12, 9, 13, 1); 
            Console.WriteLine($"\nFrom coordinates {pools[6]} pool {poolNames[6]}"); 
            Console.WriteLine($"Final Distance is {d1:F2} miles to pool {poolNames[7]}"); 
            Console.ReadKey();





            Console.Read();
        }
    }
}

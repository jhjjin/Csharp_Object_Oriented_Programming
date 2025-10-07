using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Testing Animal class --------");
            Animal[] anm = new Animal[2];
            anm[0] = new Animal();
            anm[1] = new Animal(7, "MR.T");
            anm[0].Name = "Frisky";
            anm[1].Age = 8;
            for (int i = 0; i < 2; i++)
                Console.WriteLine("#{0}: {1}", i + 1, anm[i].ToString());
            anm[0].Move();

            Console.WriteLine("-----Testing Dog class-------");
            Dog[] d = new Dog[2];
          
            d[0] = new Dog();
            d[1] = new Dog(7, "Kiki", "chiwawa");
            d[0].Breed = "golden retriever";
            d[0].Name = "Kota";
            d[1].Age = 3;
            for (int i =0; i < 2; i++)
                Console.WriteLine("#{0}: {1}", i+1, d[i].ToString());
            d[0].Move();
            d[1].Bark();

            //Using the uitilites Class -> access the static mumeber directly Class name
            Console.WriteLine("Between the 2 dogs, the older one is at the age of " + Utilities.Higher(d[0].Age, d[1].Age));
            
            Console.WriteLine("--------Testing Bird clas---------");
            Bird[] b = new Bird[2];
            b[0] = new Bird();
            b[1] = new Bird(2, "Lucy", "Yellow");
            b[0].Name = "didi";
           
            for (int i = 0; i < 2; i++)
                Console.WriteLine("#{0}: {1}", i + 1, b[i].ToString());
            b[0].Move();
            b[1].Chirp();
            Console.Read();
        }
    }
}

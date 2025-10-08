using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Date newDate = new Date(01, 09, 2021);
            
            Book myBook = new Book("C++ Programming", "John Smith", newDate);
            myBook.Price = 100.00;
           
            Console.WriteLine("Book Details:");
            myBook.ToString(); 
            myBook.Read(); 
            myBook.Donate();
            Console.WriteLine("Publication Year of the Book: {0}", myBook.PublicationDate.Year);
            Console.WriteLine();

            
            Magazine herMag = new Magazine();
            herMag.Title = "Keto for Life";
            herMag.EditorInChief = "Paula Wang";
            herMag.Price = 20.00; 
            Console.WriteLine("Magazine Details:");
            herMag.ToString(); 
            herMag.Subscribe();
            herMag.Price=18.80;
            herMag.ToString();
            Console.WriteLine();

            Console.Read();

        }
    }
}

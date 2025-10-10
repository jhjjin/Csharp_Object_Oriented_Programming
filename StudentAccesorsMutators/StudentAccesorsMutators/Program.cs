using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace StudentAccessorsMutators
{

    class Program
    {
        
        static void Main(string[] args)
        {
            //instantiate 2 objects of Student class
            Student std01 = new Student("Jan pastor");
            Student std02 = new Student("Ethan Wang", " A02", 3.68);
            Student std03 = new Student("Linda smith", " A02");
            //Testing behaviors
            std01.DisplayInfo();
            std02.DisplayInfo();
            std03.DisplayInfo();


            std01.Study("Computer Engineering");
            std02.PayFees(2000);
            std03.Study("History");

            // Encapsulation -> Accessor and Mutator
            Console.WriteLine("---------- Accessors and Mutators ----------------");
            // Display the std03 name (name is private )
            Console.WriteLine("Stduent #3's name is " + std03.GetName());

            //change the Ethan Wang and gpa std02
            std02.SetGpa(3.98);
            Console.WriteLine("Ethan has a new GPA of {0}", std02.GetGpa());
            Console.Read();
        }
    }
   

    
}


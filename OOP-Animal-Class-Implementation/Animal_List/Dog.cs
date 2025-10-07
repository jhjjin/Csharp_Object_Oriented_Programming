using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPBasics
{
    class Dog:Animal //inheritance
    {
        private string breed;
        
        public Dog():base()
        {
            breed = "unknown";
        }
        public Dog(int a, string nm, string b):base(a,nm) // Inheritance
        {
            breed = b;
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public void Bark()
        {
            Console.WriteLine(" The {0} of age {1} is barking loudly", breed, age);
        }
        public override void Move()
        {
            Console.WriteLine(" The {0} of age {1} is running quickly to the hills", breed, age);

        }

        public override string ToString()
        {
            string outStr = " A " + breed + " dog: ";
            outStr += " age: " + Age + ",      name " + name;
            return outStr;
        }
        ~Dog() { }
    }
}

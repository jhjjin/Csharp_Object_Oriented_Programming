using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPBasics
{
    class Animal
    {
        protected int age;
        protected string name;

        public Animal()
        {
            age = 2;
            name = "unknown";

        }

        public Animal(int a, string nm)
        {
            age = a;
            name = nm;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else

                    age = 0;

            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Move() //Override 
        {
            Console.WriteLine("{0} is moving quickly", name);
        }
        public override string ToString()
        {
            return "A " + age.ToString() + "-year-old animal by the name of " + name;
        }
        ~Animal() { }

        
    }
}

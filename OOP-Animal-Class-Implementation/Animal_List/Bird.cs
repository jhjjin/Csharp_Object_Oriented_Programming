using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OOPBasics
{
    class Bird : Animal
    {
        private string color;

        public Bird() : base()
        {
            color = "yellow";
        }

        public Bird(int a, string nm, string c) : base(a, nm)
        {

            color = c;

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override void Move()
        {
            Console.WriteLine("The {0}-colored bird is flying high", color);
        }
        public void Chirp()
        {
            Console.WriteLine("The {0}-colored bird is chirping. It has a beautiful voice", color);
        }
        public override string ToString()
        {
            string outStr = " A " + color + " bird: ";
            outStr += " age: " + Age + ",      name " + name;
            return outStr;
        }
        ~Bird() { }

    }
}

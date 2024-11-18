using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupProject2
{
    class Location
    {
        private int x;
        private int y;

        public Location()
        {
            x = 0;
            y = 0;
        }
        public Location(int xs, int ys)
        {
            x = xs;
            y = ys;
        }
        
        public int X
        {
            get { return x; }
            set {
                if (value > 0)
                    x = value;
                else 
                    x= 0;
                 }
        }
        public int Y
        {
            get { return y; }
            set {
                if (value > 0)
                    y = value;
                else
                    y = 0;
                }
        }
        public override string ToString()
        {
            string str = "The location of the pool is ( " + x + " , " + y + ")";
            return str;
        }
        ~Location() { }
    }
}

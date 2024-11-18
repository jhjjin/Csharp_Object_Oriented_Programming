using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupProject2
{
    class Pool
    {
        private Temperature temp = new Temperature();
        private Location loc = new Location();
        public static int Count = 0;
      

        public Pool(Temperature temp1, Location loc1)
        {
            temp = temp1;
            loc = loc1;
            Count++;

        }
        
        public Temperature Temp
        {
            get { return  temp; }
            set {  temp = value; }
        }
        public static double FindDistance(double x1, double x2, double y1, double y2)
        {
            double point1, point2;
            point1 = x1 - x2;
            point2 = y1 - y2;
            double a = (point1*point1)+(point2*point2);
            double d = Math.Sqrt(a);
            return d;
        }

        public override string ToString()
        {
            string str = "The pool is at location" + loc + " with temperature" + temp + ("degrees");
            return str;
        }

        ~Pool() { }
        
    }
}

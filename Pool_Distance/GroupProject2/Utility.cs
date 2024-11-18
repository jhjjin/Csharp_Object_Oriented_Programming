using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject2
{
    class Utility
    {
        static public double Lesser(double point1, double point2)
        {
            return Math.Min(point1, point2);
         }
        static public double Lesser2(double point1,double point2, double point3)
        {
            if(point1 < point2 && point1 <point3)
            {
                return point1;
            }
            else {return Math.Min(point2, point3); }
        }
        static public double Lesser3(double point1, double point2, double point3, double point4)
        {
            if (point1 < point2 && point1 < point3 && point1 < point4)
            {
                return point1;
            }
            else if (point2 < point3 && point2 < point4)
            {
                return point2;
            }
            else { return Math.Min(point3, point4); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupProject2
{
    class Temperature
    {
        private double degree;
        private string scale;

        public Temperature()
        {
            degree = 0.0;
            scale = "unknown";
        }
        public Temperature (double deg, string scal)
        {
            degree = deg;
            scale = scal;
        }
       
        public double Degree
        {
            get { return degree; }
            set {
                if (value > 98 && value < 104)
                    degree = value;
                else
                    degree = 0;
            }
        }
        public string Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        public override string ToString()
        {
            string str = "The temperature of the pool is " + degree + " degrees with a scale of " + scale;
            return str;
        }
        ~Temperature() { }
    }
}

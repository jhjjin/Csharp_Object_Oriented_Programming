using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _4_18_24
{
    class Date
    {
        int mm = 01;
        int dd = 01;
        int yy = 2000;
        public Date(int m, int d, int y)
        {
            mm = m;
            dd = d;
            yy = y;
        }
        public int Mm
        {
            get { return mm; }
            set { if (value < 13 && value > 0)
                    mm = value;
                else
                    mm = 1;
            }
        }
        public int Dd
        {
            get { return dd; }
            set
            {
                if (value < 32 && value > 0)
                    dd = value;
                else
                    dd = 1;
            }
        }
        public int Yy
        {
            get { return yy; }
            set
            {
                if (value > 0)
                    yy = value;
                else
                    yy = 2000;
            }
        }

        public override string ToString()
        {
            string outStr;
            if (mm < 10) // single digic of the month
                outStr = "0" + mm.ToString();
            else
                outStr = mm.ToString();
            outStr += "/";

            if (dd < 10) // single digic of the day
                outStr = "0" + dd.ToString();
            else
                outStr = dd.ToString();
            outStr = "/";
            outStr += yy.ToString();
            return outStr;

        }
        // destructor

        ~Date() { }

    }
    
}

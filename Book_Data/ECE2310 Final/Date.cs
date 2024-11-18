using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final
{
    class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(int mm, int dd, int yr)
        {
            Month = mm;
            Day = dd;
            Year = yr;
            Console.WriteLine("The Date is {0}/{1}/{2}", mm, dd, yr);
        }
        public void DisplayDate(int mm, int dd, int yr)
        {
            month = mm;
            day = dd;
            year = yr;

            Console.WriteLine("The Date is {0}/{1}/{2}", mm, dd, yr);
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        ~Date() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_18_24
{
    class Employee
    {
        private string empNum = "********";
        private Name empName = new Name(); // Composition 
        private double totalSales = 5000;
        private Date dob;

        public Employee(string num, Name name01, double s, Date date) // Overload constructuion
        {
            empNum = num;
            empName = name01;
            totalSales = s;
            dob = date;
        }
        public Employee (string num, string fn, string ln, double s, int m, int d, int y) //first name and last name
        {
            Name name01 = new Name(fn, ln); // Overload constructure
            empNum = num;
            empName = name01;
            totalSales = s;
            Date dd = new Date(m, d, y);
            dob = dd;

        }
        public Name EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public Date Dob
        {
            get { return dob;}
            set { dob = value; }
        }
        public override string ToString()
        {
            string outStr = "Employee number: " + empNum + "\n";
            outStr += "Employee name: " + empName.ToString();
            outStr += "\n Date of Birth: " + dob.ToString();
            outStr += "\nTotal Sales: $: " + totalSales + "\n";
            
            return outStr;
        }
    }
}

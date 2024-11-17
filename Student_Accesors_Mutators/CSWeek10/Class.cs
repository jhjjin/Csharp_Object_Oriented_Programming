using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSWeek10
{
    class Student
    {
        // data members
        private double gpa;
        private string id;
        private string name;
        public Student()
        {
            name = "unkown";
            gpa = 3.5;
            id = "unkown";
        }

        public Student(string nm, string idd)

        {
            name = nm;
            gpa = 3.5;
            id = idd;
        }
        
        
        public Student(string nm, string idd, double g)
        {
            name = nm;
            gpa = g;
            id = idd;
        }
        public Student(string nm)
        {
            name = nm;
            gpa = 3.5;
            id = "unknown";
        }
       
        // Accessors
        public string GetName()
        {
            return name;
        }
        public double GetGpa() 
        {
            return gpa;
        }
        public string GetId() 
        {
            return id;
        }

        // Mutators
        public void SetGpa(double g)
        {
            gpa = g;
        }
        public void SetName(string nm)
        {
            name = nm;
        }
        public void Study(string major)
        {
            Console.WriteLine(name + " studys " + major + " at Cal Poly");
        }
        public void PayFees(double d)
        {
            Console.WriteLine(name + " says $ " + d.ToString() + " this semester");
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Student name : {0}\tID:{1}\tGPA:{2}", name, id, gpa);
        }
    }

}


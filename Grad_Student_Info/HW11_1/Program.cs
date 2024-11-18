using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GraduateStudent gradstudent = new GraduateStudent(100, "Hyukjin", "B.S", "Cal Poly Pomona");
            UnderGraduate undergradStudent = new UnderGraduate(101, "Jeong", "Freshman");

            Console.WriteLine("Graduate Stduent Info:");
            gradstudent.Display();
            Console.WriteLine("Undergraduate Student Info:");
            undergradStudent.Display();

            Console.Read();
                
        }
    }
}

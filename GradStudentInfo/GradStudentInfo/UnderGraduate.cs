using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradStudentInfo
{
    class UnderGraduate:Student
    {
        private string classification;
        
        public UnderGraduate(int ID, string nm, string classifi):base(ID,nm)
        {
            classification = classifi;
        }
        public override void Display()
        {
            Console.WriteLine("Student ID {0} Student Name {1}, the classification is {2}", studentID, name, classification);
        }
        ~UnderGraduate() { }
    }
}

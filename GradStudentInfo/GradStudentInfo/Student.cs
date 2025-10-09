using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradStudentInfo
{
    class Student
    {
        protected int studentID;
        protected string name;

        public Student(int ID, string nm)
        {
            studentID = ID;
            name = nm;
        }
        public virtual void Display()
        {
            Console.WriteLine("Student name is {0} and the ID is {1}", studentID, name);
        }
        ~Student() { }
    }
}

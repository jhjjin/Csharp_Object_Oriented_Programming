using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_1
{
     class GraduateStudent:Student
    {
        private string underGraduateType;
        private string location;

        public GraduateStudent(int ID, string nm, string type, string loc):base(ID, nm)
        {
            underGraduateType = type;
            location = loc;
        }
        public override void Display()
        {
            Console.WriteLine("Undergaduate degree type: {0} and Institution Location: {1}", underGraduateType,location);
        }
        ~GraduateStudent() { }
    }
}

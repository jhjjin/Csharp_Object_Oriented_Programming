using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_18_24
{
    class Name
    {
        private string firstName;
        string lastName;

        public Name()
        {
            firstName = "unKnown";
            lastName = "";
        }
        public Name(string firstnm)
        {
            firstName = firstnm;
            lastName = "unkonwn";

        }
        public Name(string firstnm, string lastnm)
        {
            firstName = firstnm;
            lastName = lastnm;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string firstnm)
        {
            firstName = firstnm;
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }   
        
        public override string ToString()
        {
            return firstName + " " + lastName.ToString();
        }

        ~Name() { }
    }
}

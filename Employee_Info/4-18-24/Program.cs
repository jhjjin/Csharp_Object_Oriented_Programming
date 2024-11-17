using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Encapsulation example


namespace _4_18_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Name[] name = new Name[3];
            name[0] = new Name();
            name[1] = new Name("Gabby");
            name[2] = new Name("Jean", "Wang");
            for (int i = 0; i < 3; i++)
                Console.WriteLine("name[{0}]: {1}", i, name[i].ToString());

            //What is the first name of person #3?
            Console.WriteLine("The first name of person #3 is " + name[2].GetFirstName());

            //display the full name of person #1 as John Adams
            
            name[0].SetFirstName("John");
            name[0].LastName = "Adams";
            // display the full name of person #1
            Console.WriteLine("The full name of person #1 is: " + name[0].ToString());

            Console.WriteLine("--------------testing Employee Clss -----------------");
            Date[] day = new Date[2];
            day[0] = new Date(1, 1, 2000);
            day[1] = new Date(12, 6, 1990);
            Employee[] emps = new Employee[2]; // only has 2 constructure
            emps[0] = new Employee("123456", name[2], 1000, day[0]);
            emps[1] = new Employee("000008", "Abigail", "smith", 2000, 12, 12 , 1998);
            for(int i = 0; i < 2; i++)
                Console.WriteLine("Employee #{0}:\n{1}", i+1, emps[i].ToString());

            //Access the what is the last name 
            Console.WriteLine("The last name of Employee #2 is " + emps[1].EmpName.LastName);

            Console.WriteLine("-------------Adding dob as the data member of Employee class -----------\n");
            Date[] days = new Date[2];
            days[0] = new Date(1 ,1 ,2000);
            days[1] = new Date(12 , 6 ,1490);
            for (int i = 0; i < 2; i++)
                Console.WriteLine(days[i].ToString());

            days[0].Dd = 30;
            days[1].Mm = 99;
            days[0].Yy = 2023;
            Console.WriteLine("------------Testing properties --------------");
            for (int i = 0; i < 2; i++)
                Console.WriteLine(days[i].ToString());

            Console.Read();
        }
    }
}

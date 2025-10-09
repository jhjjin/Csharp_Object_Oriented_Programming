using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePay
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Employee employee = new Employee(101, "Mike","Johnson", 50000);

            Console.WriteLine("Employee Number: {0}", employee.GetEmployeeNumber());
            Console.WriteLine("Name: {0} {1}", employee.GetFirstName(), employee.GetLastName());
            Console.WriteLine("Take-Home pay: ${0}", employee.CalculateHomePay());


            Console.WriteLine("-----changing employee using mutator method-----");
            Console.WriteLine("Enter new employee number: ");
            int newEmployeeNumber;
            while(!int.TryParse(Console.ReadLine(), out newEmployeeNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            employee.SetEmployeeNumber(newEmployeeNumber);

            Console.WriteLine("Enter new first name: ");
            string newFirstName = Console.ReadLine();
            employee.SetFirstName(newFirstName);

            Console.WriteLine("Enter new last name: ");
            string newLastName = Console.ReadLine();
            employee.SetLastName(newLastName);

            Console.WriteLine("Employee Number: {0}", employee.GetEmployeeNumber());
            Console.WriteLine("Name: {0} {1}", employee.GetFirstName(), employee.GetLastName());
            Console.WriteLine("Take-Home pay: ${0}", employee.CalculateHomePay());
            Console.Read();
            
        }
    }
}

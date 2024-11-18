using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw08
{
    internal class Employee
    {
        private int employeeNumber;
        private string firstName;
        private string lastName;
        private double monthlySalary;

        public Employee()
        {
            employeeNumber = 0;
            firstName = "";
            lastName = "";
            monthlySalary = 0;
        }
        public Employee(string firstNm, string lastNm, int employeeNum, double monthlySal)
        {
            firstName = firstNm;
            lastName = lastNm;
            employeeNumber = employeeNum;
            monthlySalary = monthlySal;
        }
        
       
        public double CalculateAnnualPay()
        {
            return monthlySalary * 12;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Number: " + employeeNumber);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Monthly Salary: $ " + monthlySalary);
            Console.WriteLine("Annual Pay: $ " + CalculateAnnualPay());
        }
    }
}

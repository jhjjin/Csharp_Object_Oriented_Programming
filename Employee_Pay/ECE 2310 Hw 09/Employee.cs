using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Hw_09
{
    class Employee
    {
        private int employeeNumber;
        private string firstName;
        private string lastName;
        private double totalSales;

        public const double COMMISION_RATE = 0.09;
        public const double FEDERAL_TAX_RATE = 0.18;
        public const double RETIREMENT_CONTRIBUTION = 0.10;
        public const double SOCIAL_SECURITY_TAX_RATE = 0.06;

        public Employee()
        {
            
        }
        public Employee(int employeeNm, string firstNm, string lastNm, double totalSale)
        {
            employeeNumber = employeeNm;
            firstName = firstNm;
            lastName = lastNm;
            totalSales = totalSale;
        }
        public int GetEmployeeNumber()
        {
            return employeeNumber;
        }
        public void SetEmployeeNumber(int employeeNm)
        {
            employeeNumber = employeeNm;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string firstNm)
        {
            firstName = firstNm;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string lastNm)
        {
            lastName = lastNm;
        }
        public double GetTotalSales()
        {
            return totalSales;
        }
        public void SetTotalSales(double totalSale)
        {
            totalSales = totalSale;
        }
        public double CalculateHomePay()
        {
            double commision = totalSales * COMMISION_RATE;
            double federalTax = (totalSales + commision) * FEDERAL_TAX_RATE;
            double retirementContribution = (totalSales + commision) * RETIREMENT_CONTRIBUTION;
            double socialSecurityTax = (totalSales + commision) * SOCIAL_SECURITY_TAX_RATE;
            return (totalSales + commision) - federalTax - retirementContribution - SOCIAL_SECURITY_TAX_RATE;
        }
    }
}

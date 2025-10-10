# EmployeePay — C# (.NET Framework 4.7.2 Console Application)
```
This project calculates an employee’s take-home pay based on total sales and several deduction rates.
It demonstrates the use of classes, constants, accessor/mutator methods, and simple business logic encapsulation in C#.
```
---
## 🧱 Project Structure
```
EmployeePay/
├── Employee.cs              // Employee class with calculation logic
├── Program.cs               // Console interaction
├── EmployeePay.csproj       // .NET Framework 4.7.2 project file
└── Properties/
    └── AssemblyInfo.cs
```
---
## 🧩 Features
```
- Stores employee details:
- employeeNumber, firstName, lastName, and totalSales
- Calculates:
       Commission at 9% of sales
       Federal tax at 18%
       Retirement contribution at 10%
       Social security tax at 6%
       Allows the user to update employee information using mutator methods
       Displays the final take-home pay
```

---

## 💡 Formula
```
- commission = totalSales * COMMISSION_RATE
- taxBase = totalSales + commission
- federalTax = taxBase * FEDERAL_TAX_RATE
- retirement = taxBase * RETIREMENT_CONTRIBUTION
- socialSecurity = taxBase * SOCIAL_SECURITY_TAX_RATE
- takeHome = taxBase - (federalTax + retirement + socialSecurity)
```

---
## 🧠 Concepts Demonstrated
```
Object-Oriented Programming (Encapsulation)
Constants and computation logic
Input validation using TryParse
Accessor and mutator method design
```

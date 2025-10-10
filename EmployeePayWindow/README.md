# EmployeePayWindow — C# (.NET Framework 4.7.2, Windows Forms)
```
A simple Windows Forms app that computes an employee’s net take-home commission from weekly sales.
The app applies a 7% commission to the entered sales and then deducts federal tax (18%), retirement (15%), and social security (9%) from the commission to display the net pay.
```
---
## 🗂 Project Structure
```
EmployeePayWindow/
├── EmployeePayWindow.csproj
├── EmployeePayWindow.sln
├── Form1.cs               // Event handlers and calculation logic
├── Form1.Designer.cs      // UI layout (WinForms designer)
├── Form1.resx             // Form resources
├── Program.cs             // App entry point
└── Properties/
    ├── AssemblyInfo.cs
    ├── Resources.resx / Resources.Designer.cs
    └── Settings.settings / Settings.Designer.cs
```
---
## ✨ Features
```
- Input: employee name and total weekly sales
- Calculates:
          Commission = 7% of total sales
          Deductions on the commission amount
          Federal tax: 18%
          Retirement: 15%
          Social Security: 9%
          Outputs each deduction and the Total Net Pay
          Clear and Exit buttons
```
---
## 🧮 Calculation
```
- commission = totalSales * 0.07
- fedTax     = commission * 0.18
- retirement = commission * 0.15
- social     = commission * 0.09
- netPay     = commission - (fedTax + retirement + social)
```

---

## 🧠 Concepts Demonstrated
```
- Windows Forms UI (controls, events, designer)
- Basic numeric input, validation, and formatting
- Separation of UI and calculation logic within the form
```

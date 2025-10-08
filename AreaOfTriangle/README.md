# 🔺 AreaOfTriangle — Heron’s Formula (C#)

A simple C# console application that calculates the **area of a triangle** using **Heron’s formula**.  
This project demonstrates basic function definition, mathematical computation, and console output in C#.



## 📂 Project Structure
AreaOfTriangle/
├── Program.cs              # Main console application  
├── AreaOfTriangle.csproj  
└── AreaOfTriangle.sln  



## 🧮 Formula Used
For a triangle with sides **a**, **b**, and **c**:

1. Calculate the semi-perimeter:  
   s = (a + b + c)/2
   

2. Compute the area:  
   A = sqrt{s(s - a)(s - b)(s - c)}

## 🧠 Code Explanation
AreaOfTriangle(double a, double b, double c):
Calculates the triangle’s area using Heron’s formula.
Console.WriteLine():
Displays the result in the console.
Optional: Distance2() function (commented out) demonstrates how to compute the distance between two points in 2D space.
   



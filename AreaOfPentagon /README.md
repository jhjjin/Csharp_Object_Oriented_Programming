# AreaOfPentagon — Triangulation Method (C#)

A simple C# program to calculate the **area of a pentagon** given 5 Cartesian coordinate points,  
using the **triangulation method** and **Heron’s formula**.  
Includes both **WinForms UI** and **.NET 7 console** implementations.

## 📂 Project Structure
```
AreaOfPentagon/
├── Program.cs            # Console version (recommended; cross-platform)
├── Calculation.cs        # WinForms logic (optional; Windows only)
├── Calculation.Designer.cs
└── AreaOfPentagon.sln / .csproj
```

## 🧮 Method
1. **Distance between points:**  
   d(p, q) = sqrt{(x_p - x_q)^2 + (y_p - y_q)^2} 

2. **Area of a triangle (Heron’s formula):**  
   s = (a + b + c)/2   
   A = sqrt{s(s - a)(s - b)(s - c)} 

3. **Triangulation approach:**  
   The pentagon is divided into 3 triangles:  
   - △(p1, p2, p3)  
   - △(p3, p5, p2)  
   - △(p2, p4, p5)

**Important:** The points must be entered **in order** (clockwise or counterclockwise)  
to form a simple, non-self-intersecting pentagon.

## ✅ Example Output
```
Area of Pentagon (by triangulation) — .NET 7 Console
Enter coordinates for 5 points (x1..x5, y1..y5).
Tip: Use decimal point '.' for decimals.

x1 = 0
y1 = 0
x2 = 2
y2 = 0
x3 = 3
y3 = 1
x4 = 1.5
y4 = 2
x5 = 0
y5 = 1

Area = 3.50
```

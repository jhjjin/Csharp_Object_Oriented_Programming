# WindowScoreGeneratorCurve — C# (.NET Framework 4.7.2, Windows Forms)
```
A Windows Forms app that generates random exam scores, reports the class average, and applies a curve to target an average of 85.
It displays scores before and after curving in two list boxes.
```
---
## 🧱 Project Structure
```
WindowScoreGeneratorCurve/
├── WindowScoreGeneratorCurve.sln
├── WindowScoreGeneratorCurve.csproj
├── Form1.cs            // event handler, generation, averaging, curving
├── Form1.Designer.cs   // UI layout (two ListBox controls)
├── Form1.resx
├── Program.cs          // WinForms entry point
└── Properties/
    ├── AssemblyInfo.cs
    ├── Resources.resx / Resources.Designer.cs
    └── Settings.settings / Settings.Designer.cs
```
---
## ✨ Features
```
- Generates N = 26 integer scores uniformly in [60, 100]
- Shows the list before and after curving
- Computes class average and the curve ratio r = 85 / average
- Caps curved scores at 100
- Simple UI with a button and two list boxes
```
---
## 🧪 Example Flow
```
- Click Generate / Curve (your current button text is "button1").
- Left list shows Student ID# 0..25 with original scores.
- A message box pops:
    “The class is doing good” if average ≥ 85 (no curve), or
    “Curve the scores with the ratio of r”
- Right list shows curved scores (rounded, max 100).
```
---
## 🧠 Concepts Demonstrated
```
- Basic statistics (mean) and grading curves
- Random number generation with inclusive bounds
- In-place transformation of arrays
- Simple WinForms UI with ListBox and Label
```

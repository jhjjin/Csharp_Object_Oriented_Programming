# SimpleDesign — C# (.NET Framework 4.7.2, Windows Forms)
```
A small Windows Forms app that takes an integer n and displays factorial values from 1! to n!.
It also computes a running estimate est = 1 + Σ (1 / i!) (useful as a partial sum for e), and prints results into the UI.
```
---
## 🧱 Project Structure
```
SimpleDesign/
├── SimpleDesign.sln
├── SimpleDesign.csproj
├── Form1.cs           // Event handlers, factorial and input logic
├── Form1.Designer.cs  // UI layout (WinForms designer)
├── Form1.resx         // Form resources
├── Program.cs         // App entry point
└── Properties/
    ├── AssemblyInfo.cs
    ├── Resources.resx / Resources.Designer.cs
    └── Settings.settings / Settings.Designer.cs

```
---
## ✨ Features
```
- Input: non-negative integer n
- Output: the sequence 1!, 2!, …, n!
- Computes partial sum est = 1 + 1/1! + 1/2! + … + 1/n!
- Simple GUI with Enter n, Calculate button, and output box
```
---
## 🧠 Concepts Demonstrated
```
- Windows Forms UI (controls, designer, event handling)
-Input validation with int.TryParse
- Iterative factorial computation
- Building a mathematical series using loop accumulation
- Writing formatted text to a multiline TextBox
```

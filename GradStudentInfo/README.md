# GradStudentInfo — C# (.NET Framework 4.7.2 Console Application)
```
A small console app demonstrating inheritance, access modifiers (protected), and polymorphism with virtual/override methods using a simple university student model.
```

---
## 🧱 Project Structure
```
GradStudentInfo/
├── GradStudentInfo.csproj
├── Program.cs
├── Student.cs
├── GraduateStudent.cs
└── UnderGraduate.cs
```
---

## ✨ What it shows
```
- Base class: Student with studentID and name
- Derived classes:
- GraduateStudent — adds undergraduate degree type and institution location
- UnderGraduate — adds academic classification (e.g., Freshman)
- Polymorphic Display() method overridden in both derived classes
- Simple object instantiation and output in Program.Main
```
--- 
## 🧠 Concepts Demonstrated
```
- Inheritance (GraduateStudent and UnderGraduate extend Student)
- Polymorphism with virtual/override
- Constructor chaining with base()
- Access modifiers and field visibility
```

# GroceryList — C# (.NET Framework 4.7.2 Console Application)
```
A simple console-based grocery expense calculator built with Object-Oriented Programming principles in C#.
It demonstrates class composition, encapsulation, and method overriding to display an itemized grocery list with the total expense.
```
---
## 🧱 Project Structure
```
GroceryList/
├── GroceryList.sln
├── GroceryList.csproj
├── Program.cs           // Main entry point, creates and displays grocery objects
├── Grocery.cs           // Combines item classes and calculates total expense
├── Milk.cs              // Represents a milk item
├── Bread.cs             // Represents a bread item
├── Eggs.cs              // Represents an egg item
└── Properties/
    └── AssemblyInfo.cs
```
---
## 🧩 Features
```
- Defines separate classes for grocery items:
    Milk
    Bread
    Eggs
-Each item contains:
   UnitPrice → price per unit
   Quantity → number of items purchased
   TotalPrice() → returns unitPrice * quantity
   Grocery class aggregates all items and calculates the total cost
   Program outputs a neatly formatted grocery summary with total expense
```
---
## 🧠 Concepts Demonstrated
```
- Encapsulation — private fields with public properties
- Composition — Grocery class contains multiple item objects
- Polymorphism — ToString() overridden for custom output
- Reusability — consistent class design for multiple item types
```

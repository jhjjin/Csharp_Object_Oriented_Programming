# 📚 BookData — Inheritance & Composition in C#

A small C# console project that models **reading materials** using OOP.  
It demonstrates **inheritance**, **encapsulation**, **method overriding (custom ToString)**, and **composition** (`Book` has a `Date`).

---

## 📂 Project Structure
BookData/
├── Program.cs             # Demo app (creates a Book and a Magazine)  
├── ReadingMaterial.cs     # Base class with Title & Price  
├── Book.cs                # Derived class (adds Author, PublicationDate)  
├── Date.cs                # Simple date value object (Month/Day/Year)  
└── Magazine.cs            # Derived class (adds EditorInChief)

---

## 🧠 What it Shows
- **Inheritance:** `Book` and `Magazine` inherit from `ReadingMaterial`.
- **Composition:** `Book` contains a `Date` object for publication date.
- **Encapsulation:** All fields are private with public properties.
- **Polymorphism hook:** `ReadingMaterial` defines a `virtual ToString()` method that derived types can override.

> Note: In this codebase `ToString()` is declared as `virtual void ToString()`.  
> That’s fine for the demo, but idiomatic C# overrides `public override string ToString()` from `object`.  
> See the _Improvements_ section below.

# ✅ Example Output
```
The Date is 1/9/2021
Book Details:
C++ Programming, author is Jay Jeong, published on BookData.Date
Read a book title: C++ Programming
Donate the book John Smith and Date BookData.Date
Publication Year of the Book: 2021

Magazine Details:
Keto for Life editor-in-chief is : Paula Wang,  price: $20
Keto for Life editor-in-chief is: Paula Wang and price 20
Keto for Life editor-in-chief is : Paula Wang,  price: $18.8
```

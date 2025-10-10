# TestValueRefSumArray — C# (.NET Framework 4.7.2 Console Application)
```
- A small console app that demonstrates:
    Array initialization & traversal
    Summing arrays
    Method overloading
    Pass-by-reference (ref) vs pass-by-value
    A simple arithmetic series function (PrintSum)
```
---
## 🧱 Project structure
```
TestValueRefSumArray/
├── TestValueRefSumArray.sln
├── TestValueRefSumArray.csproj
├── Program.cs                // arrays, ref/value tests, sum functions
└── Properties/
    └── AssemblyInfo.cs
```
---
## 🧩 What the program does
```
- Builds an array k[0..99] with values 1..100 and prints each element with its index.
- Calls SumArray(k) to compute and print the total sum of the array.
- Shows the difference between:
    Test(int m, ref int n) (pass m by value, n by reference; returns m*m)
    Test(ref int m, ref int n) (passes both by reference; squares m and adds it into n)
- Calls PrintSum(100) to display the sum 1 + 2 + ... + 100.
```
---
## 🧠 Concepts demonstrated
```
- Arrays and for-loops
- Aggregation with a simple accumulator (SumArray)
- Method overloading and parameter passing semantics (ref vs by value)
- Summation of arithmetic series (PrintSum)
```

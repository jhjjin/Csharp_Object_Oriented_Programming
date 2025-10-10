# PoolDistance — C# (.NET Framework 4.7.2 Console Application)
```
A console app that models swimming pools with a location and water temperature, then computes pairwise distances between pools and reports the closest one(s).
It demonstrates composition (Pool has a Location and Temperature), static utility methods, and simple numerical computations.
```
---
## 🧱 Project Structure
```
PoolDistance/
├── PoolDistance.sln
├── PoolDistance.csproj
├── Program.cs           // Demo runner: creates pools, computes distances, prints closest
├── Pool.cs              // Pool aggregate + static distance and instance count
├── Location.cs          // X, Y (with clamping), ToString()
├── Temperature.cs       // Degree + Scale (range guard), ToString()
├── Utility.cs           // Min-of-2/3/4 helpers
└── Properties/
    └── AssemblyInfo.cs
```
---
## ✨ Features
```
- Location class with X, Y coordinates and input clamping (non-positive values become 0).
- Temperature class with degree + scale (string) and range guard.
- Pool class that aggregates Location and Temperature, plus a static Count of created pools.
- Pool.FindDistance(..) to compute Euclidean distance.
- Utility helpers (Lesser, Lesser2, Lesser3) to pick the minimum of multiple distances.
- Demo in Program.Main that:
    Creates pools at preset coordinates,
    Assigns random temperatures,
    Prints distances and the closest pool(s).
```
---
## 🧠 Concepts Demonstrated
```
- Object composition and encapsulation
- Static methods and state (Pool.Count)
- Defensive setters (input clamping)
- Simple algorithm design (min selection)
```

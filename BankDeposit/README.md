# 🏦 BankDeposit — Object-Oriented Programming in C#

### 💡 Overview
This C# console project demonstrates **Object-Oriented Programming (OOP)** principles such as **inheritance**, **encapsulation**, and **polymorphism** through a simple banking system that handles **Checking** and **Saving** accounts.

---

## 🧱 Project Structure
```
BankDeposit/
│
├── BankAccount.cs   # Base class (common account logic)
├── Checking.cs      # Derived class for checking account
├── Saving.cs        # Derived class for savings account
└── Program.cs       # Main program entry
```


## ⚙️ Program Execution

## 🖥️ Example (Program.cs)
```
Checking checking = new Checking("1001", "Hyukjin", 1000);
Console.WriteLine("Checking Account:");
checking.ToString();
checking.Deposite(400);
checking.Withdraw(200);

Saving saving = new Saving("4939", "Jeong", 3000);
Console.WriteLine("\nSavings Account:");
saving.ToString();
saving.Deposite(400);
saving.Withdraw(200);


```

##🧾 Sample Output
```
Checking Account:
Account Number: 1001 Ower Name: Hyukjin Balance: 1000
400 amount deposited. New balance is 1400
200 amount withdrawn. New balance is 1200

Savings Account:
Account Number: 4939 Ower Name: Jeong Balance: 3000
400 amount deposited. New balance: 3400
200 amount withdrawn. New balance: 3200

```
## 🧠 Concepts Demonstrated
```
Encapsulation: Data hidden inside class properties.
Inheritance: Checking and Saving derived from BankAccount.
Polymorphism: Withdraw and Deposite methods overridden.
Destructor (~): Cleans up resources when the object is destroyed
```


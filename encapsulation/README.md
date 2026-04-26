# ENCAPSULATION - EXAM NOTES 📚

## What is Encapsulation?

Encapsulation means **bundling data (variables) and methods together in a class, and hiding the internal details from the outside world**. It's like a capsule that protects the contents inside!

### Simple Analogy:
- **A Capsule** - protects medicine inside
- **A Class** - protects data inside through access modifiers

---

## Why Do We Need Encapsulation?

1. **Security** - Sensitive data is protected from unauthorized access
2. **Data Validation** - We can validate data before allowing modification
3. **Flexibility** - We can change internal implementation without affecting external code
4. **Read-Only/Write-Only** - We can make data read-only or write-only as needed
5. **Easy Maintenance** - Easier to modify code without breaking external code

---

## How to Achieve Encapsulation?

### Step 1: Make variables **PRIVATE**
```csharp
private int age;  // Cannot be accessed directly from outside
```

### Step 2: Create PUBLIC methods to access and modify
```csharp
public int GetAge() { return age; }
public void SetAge(int newAge) { age = newAge; }
```

### Step 3: Add Validation (Optional but Important)
```csharp
public void SetAge(int newAge)
{
    if (newAge > 0 && newAge < 120)
        age = newAge;
    else
        Console.WriteLine("Invalid age!");
}
```

---

## Access Modifiers in C#

Access modifiers control **WHO can access** a class member.

### The 6 Access Modifiers:

#### 1. **PUBLIC** 🟢
- Accessible from **ANYWHERE** in the program
- Even from outside the class and outside the assembly

```csharp
public class Student
{
    public string name = "John";  // Anyone can access
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine(s.name);  // ✅ Works
        s.name = "Jane";            // ✅ Works
    }
}
```

---

#### 2. **PRIVATE** 🔴
- Accessible **ONLY** within the same class
- Nobody else can access it, not even child classes

```csharp
public class Student
{
    private int age = 25;  // Only accessible inside Student class
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        // Console.WriteLine(s.age);  // ❌ ERROR: Cannot access private member
    }
}

class Teacher : Student
{
    public void ShowAge()
    {
        // Console.WriteLine(age);  // ❌ ERROR: Child cannot access private member
    }
}
```

---

#### 3. **PROTECTED** 🟡
- Accessible within the **same class** AND **child classes** (derived classes)
- NOT accessible from outside the class hierarchy

```csharp
public class Animal
{
    protected string name = "Animal";  // Can be accessed by child classes
}

class Dog : Animal
{
    public void ShowName()
    {
        Console.WriteLine(name);  // ✅ Works (child class access)
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        // Console.WriteLine(a.name);  // ❌ ERROR: Cannot access protected member
        
        Dog d = new Dog();
        d.ShowName();  // ✅ Works
    }
}
```

---

#### 4. **INTERNAL** 🔵
- Accessible **within the same assembly** (same project/DLL)
- NOT accessible from another assembly/project

```csharp
internal class MyClass  // Only accessible in this project
{
    internal string data = "secret";
}

// From another project: Cannot access
```

---

#### 5. **PROTECTED INTERNAL** 🟣
- Accessible within the same assembly AND child classes from other assemblies
- Combination of `protected` and `internal`

```csharp
public class Vehicle
{
    protected internal string color;  // Can be accessed by:
                                       // 1. Child classes in other assemblies
                                       // 2. Any class in same assembly
}
```

---

#### 6. **PRIVATE PROTECTED** ⚫
- Accessible only within the same class AND child classes in the **same assembly**
- Most restrictive (rarely used)

```csharp
public class Base
{
    private protected string secret;  // Only accessible by child classes in SAME assembly
}
```

---

## Access Modifier Summary Table

| Modifier | Same Class | Child Class (Same Assembly) | Child Class (Other Assembly) | Same Assembly | Other Assembly |
|----------|---|---|---|---|---|
| `public` | ✅ | ✅ | ✅ | ✅ | ✅ |
| `private` | ✅ | ❌ | ❌ | ❌ | ❌ |
| `protected` | ✅ | ✅ | ✅ | ❌ | ❌ |
| `internal` | ✅ | ✅ | ❌ | ✅ | ❌ |
| `protected internal` | ✅ | ✅ | ✅ | ✅ | ❌ |
| `private protected` | ✅ | ✅ | ❌ | ✅ | ❌ |

---

## Practical Example of Encapsulation

### ❌ BAD WAY (Without Encapsulation)
```csharp
public class BankAccount
{
    public double balance;  // Anyone can access and modify!
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.balance = 1000;
        acc.balance = -5000;  // ❌ PROBLEM: Negative balance allowed!
        Console.WriteLine("Balance: " + acc.balance);
    }
}
```

### ✅ GOOD WAY (With Encapsulation)
```csharp
public class BankAccount
{
    private double balance;  // Private - cannot be accessed directly
    
    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Amount must be positive!");
    }
    
    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Invalid withdrawal amount!");
    }
    
    // Public method to get balance
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        Console.WriteLine("Balance: " + acc.GetBalance());  // 1000
        
        acc.Withdraw(500);
        Console.WriteLine("Balance: " + acc.GetBalance());  // 500
        
        acc.Withdraw(1000);  // Output: Invalid withdrawal amount!
    }
}
```

---

## Properties in C# (Getter and Setter)

C# provides a special syntax for encapsulation using **Properties**. It's cleaner than creating separate Get/Set methods.

### Syntax:
```csharp
public dataType PropertyName
{
    get { return variable; }
    set { variable = value; }
}
```

### Example Without Validation:
```csharp
private string _name;

public string Name
{
    get { return _name; }
    set { _name = value; }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.Name = "John";           // Uses setter
        Console.WriteLine(obj.Name);  // Uses getter, Output: John
    }
}
```

### Example With Validation:
```csharp
private int _age;

public int Age
{
    get { return _age; }
    set 
    { 
        if (value >= 0 && value <= 120)
            _age = value;
        else
            Console.WriteLine("Invalid age!");
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.Age = 25;              // ✅ Valid
        Console.WriteLine(obj.Age); // Output: 25
        
        obj.Age = -5;              // ❌ Invalid - Output: Invalid age!
    }
}
```

---

## Read-Only Property (Only Getter)

```csharp
private int _id = 12345;

public int Id
{
    get { return _id; }
    // No setter - cannot be modified
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        Console.WriteLine(obj.Id);  // ✅ Works: 12345
        // obj.Id = 999;             // ❌ ERROR: No setter available
    }
}
```

---

## Write-Only Property (Only Setter)

```csharp
private string _password;

public string Password
{
    // No getter - cannot be read
    set { _password = value; }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.Password = "secret123";    // ✅ Works
        // Console.WriteLine(obj.Password);  // ❌ ERROR: No getter available
    }
}
```

---

## Auto-Implemented Properties (Shorthand)

For simple get/set without validation:

```csharp
// Old way:
private string _name;
public string Name
{
    get { return _name; }
    set { _name = value; }
}

// New way (C# 3.0+):
public string Name { get; set; }  // Much shorter!

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        obj.Name = "John";
        Console.WriteLine(obj.Name);  // Output: John
    }
}
```

---

## Real-World Example

```csharp
public class Student
{
    private string _name;
    private int _age;
    private double _gpa;
    
    // Property for Name
    public string Name
    {
        get { return _name; }
        set 
        { 
            if (value != "")
                _name = value;
            else
                Console.WriteLine("Name cannot be empty!");
        }
    }
    
    // Property for Age
    public int Age
    {
        get { return _age; }
        set 
        { 
            if (value >= 18 && value <= 40)
                _age = value;
            else
                Console.WriteLine("Age must be between 18 and 40!");
        }
    }
    
    // Property for GPA
    public double GPA
    {
        get { return _gpa; }
        set 
        { 
            if (value >= 0 && value <= 4.0)
                _gpa = value;
            else
                Console.WriteLine("GPA must be between 0 and 4.0!");
        }
    }
    
    // Display student info
    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}, GPA: {_gpa}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Rajesh";
        s.Age = 25;
        s.GPA = 3.5;
        s.Display();  // Output: Name: Rajesh, Age: 25, GPA: 3.5
        
        s.Age = 50;   // Output: Age must be between 18 and 40!
    }
}
```

---

## Important Exam Questions

**Q1. What is encapsulation?**
- A: Bundling data and methods together and hiding internal details from outside.

**Q2. Why do we need encapsulation?**
- A: For security, data validation, flexibility, and maintainability.

**Q3. What are access modifiers?**
- A: Keywords that control who can access class members (public, private, protected, internal, etc.)

**Q4. What's the difference between private and protected?**
- A: Private cannot be accessed by child classes, protected can.

**Q5. What is a property?**
- A: A special syntax for getter and setter methods in C#.

**Q6. What is a read-only property?**
- A: A property with only getter, no setter.

---

## Summary Points to Remember ✨

1. Encapsulation = Bundle data + methods + hide details
2. **Private variables** cannot be accessed directly from outside
3. Use **getter/setter methods** or **properties** to access private data
4. Always validate data in setter before modifying
5. **6 Access Modifiers**: public, private, protected, internal, protected internal, private protected
6. `public` = accessible everywhere
7. `private` = accessible only in same class
8. `protected` = accessible in same class and child classes
9. Properties use `{ get; set; }` syntax
10. Read-only property = only getter, Write-only = only setter
11. Auto-implemented properties `{ get; set; }` for simple cases
12. Always protect sensitive data with private + validation


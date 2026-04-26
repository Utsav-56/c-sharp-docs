# CONSTRUCTORS - EXAM NOTES 📚

## What is a Constructor?

A **constructor** is a **special method** that is **automatically called** when an **object** is **created**. 

It's used to **initialize** the object's fields with initial values.

### Key Points:
- Same name as the class
- No return type (not even void)
- Called automatically when object is created with `new` keyword
- Can have parameters or no parameters
- Can have multiple constructors (constructor overloading)

---

## Why Do We Need Constructors?

1. **Initialize fields** - Set default or provided values
2. **Ensure valid state** - Object starts in a valid condition
3. **Validate input** - Check if provided values are correct
4. **Setup resources** - Allocate memory, open connections, etc.
5. **Cleaner code** - No need to call separate initialization method

---

## Types of Constructors

### Type 1: Default Constructor

A constructor with **NO parameters**. Created automatically if you don't define any constructor.

```csharp
class Student
{
    public string name;
    public int age;
    
    // Default constructor (no parameters)
    public Student()
    {
        name = "Unknown";
        age = 0;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();  // Default constructor is called
        Console.WriteLine($"{s.name}, {s.age}");  // Output: Unknown, 0
    }
}
```

---

### Type 2: Parameterized Constructor

A constructor with **parameters** to accept values during object creation.

```csharp
class Student
{
    public string name;
    public int age;
    
    // Parameterized constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }
}

class Program
{
    static void Main()
    {
        // Pass values to constructor
        Student s = new Student("Rajesh", 22);
        Console.WriteLine($"{s.name}, {s.age}");  // Output: Rajesh, 22
    }
}
```

---

### Type 3: Constructor Overloading

**Multiple constructors** with different parameters in the same class.

```csharp
class Student
{
    public string name;
    public int age;
    public double gpa;
    
    // Constructor 1: Default
    public Student()
    {
        name = "Unknown";
        age = 0;
        gpa = 0.0;
    }
    
    // Constructor 2: Name only
    public Student(string n)
    {
        name = n;
        age = 0;
        gpa = 0.0;
    }
    
    // Constructor 3: Name and Age
    public Student(string n, int a)
    {
        name = n;
        age = a;
        gpa = 0.0;
    }
    
    // Constructor 4: All fields
    public Student(string n, int a, double g)
    {
        name = n;
        age = a;
        gpa = g;
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();                   // Uses Constructor 1
        Student s2 = new Student("Rajesh");           // Uses Constructor 2
        Student s3 = new Student("Priya", 21);        // Uses Constructor 3
        Student s4 = new Student("Amit", 22, 3.8);    // Uses Constructor 4
        
        Console.WriteLine($"{s1.name}, {s1.age}");    // Unknown, 0
        Console.WriteLine($"{s2.name}, {s2.age}");    // Rajesh, 0
        Console.WriteLine($"{s3.name}, {s3.age}");    // Priya, 21
        Console.WriteLine($"{s4.name}, {s4.age}");    // Amit, 22
    }
}
```

---

## `this` Keyword

The `this` keyword **refers to the current object**. Used to distinguish between field and parameter with same name.

```csharp
class Student
{
    public string name;
    public int age;
    
    public Student(string name, int age)
    {
        this.name = name;  // this.name = field, name = parameter
        this.age = age;    // this.age = field, age = parameter
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Rajesh", 22);
        Console.WriteLine($"{s.name}, {s.age}");  // Output: Rajesh, 22
    }
}
```

---

## Constructor Chaining Using `this()`

Call one constructor from another constructor using `this()`.

```csharp
class Student
{
    public string name;
    public int age;
    public double gpa;
    
    // Constructor 1: Default
    public Student() : this("Unknown", 0, 0.0)
    {
        Console.WriteLine("Default constructor called");
    }
    
    // Constructor 2: All fields
    public Student(string name, int age, double gpa)
    {
        this.name = name;
        this.age = age;
        this.gpa = gpa;
        Console.WriteLine("Parameterized constructor called");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
    }
}
```

**Output:**
```
Parameterized constructor called
Default constructor called
```

---

### Type 4: Static Constructor

A **static constructor** runs **only once** when the class is **first accessed**. Used to initialize static members.

```csharp
class Mathematics
{
    public static double PI;
    public static double E;
    
    // Static constructor - called only once
    static Mathematics()
    {
        PI = 3.14159;
        E = 2.71828;
        Console.WriteLine("Static constructor called (once)");
    }
    
    public static void Display()
    {
        Console.WriteLine($"PI: {PI}, E: {E}");
    }
}

class Program
{
    static void Main()
    {
        Mathematics.Display();  // Static constructor called here
        Mathematics.Display();  // Static constructor NOT called again
    }
}
```

**Output:**
```
Static constructor called (once)
PI: 3.14159, E: 2.71828
PI: 3.14159, E: 2.71828
```

---

## Constructor with Validation

Add validation in constructor to ensure valid object creation.

```csharp
class Person
{
    public string name;
    public int age;
    
    public Person(string name, int age)
    {
        // Validation
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty!");
            this.name = "Unknown";
        }
        else
        {
            this.name = name;
        }
        
        if (age < 0 || age > 120)
        {
            Console.WriteLine("Age must be between 0 and 120!");
            this.age = 0;
        }
        else
        {
            this.age = age;
        }
    }
    
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Rajesh", 22);
        p1.Display();  // Output: Name: Rajesh, Age: 22
        
        Person p2 = new Person("", -5);
        p2.Display();  // Output: Name: Unknown, Age: 0
    }
}
```

---

## Constructor in Inheritance

When creating a child class object, the **parent constructor is called first**, then the **child constructor**.

```csharp
class Animal
{
    public string name;
    
    // Parent constructor
    public Animal(string name)
    {
        this.name = name;
        Console.WriteLine("Animal constructor called");
    }
}

class Dog : Animal
{
    public string breed;
    
    // Child constructor
    public Dog(string name, string breed) : base(name)  // Call parent constructor
    {
        this.breed = breed;
        Console.WriteLine("Dog constructor called");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Buddy", "Labrador");
    }
}
```

**Output:**
```
Animal constructor called
Dog constructor called
```

---

## Real-World Example: Bank Account

```csharp
class BankAccount
{
    public string accountNumber;
    public string accountHolder;
    public double balance;
    
    // Constructor with validation
    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        if (string.IsNullOrEmpty(accountNumber))
            throw new Exception("Account number cannot be empty!");
        
        if (initialBalance < 0)
            throw new Exception("Initial balance cannot be negative!");
        
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }
    
    public void Display()
    {
        Console.WriteLine($"Account: {accountNumber}");
        Console.WriteLine($"Holder: {accountHolder}");
        Console.WriteLine($"Balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount("ACC123456", "Rajesh Kumar", 10000);
        acc.Display();
    }
}
```

**Output:**
```
Account: ACC123456
Holder: Rajesh Kumar
Balance: 10000
```

---

## Important Exam Questions

**Q1. What is a constructor?**
- A: A special method called automatically when object is created to initialize it.

**Q2. What's the difference between constructor and method?**
- A: Constructor is called automatically, has same name as class, no return type.

**Q3. Can constructor have return type?**
- A: No, constructors cannot have return type, not even void.

**Q4. What is constructor overloading?**
- A: Multiple constructors with different parameters in the same class.

**Q5. What does `this` keyword do?**
- A: Refers to the current object, distinguishes field from parameter.

**Q6. What is static constructor?**
- A: Called only once, used to initialize static members.

**Q7. What is `base` keyword?**
- A: Used to call parent class constructor from child class.

---

## Summary Points to Remember ✨

1. Constructor = special method for initialization
2. **Same name as class**, no return type
3. **Called automatically** when object created with `new`
4. Can have **parameters** or **no parameters**
5. Can have **multiple constructors** (overloading)
6. Use `this()` to call another constructor
7. Use `base()` to call parent constructor
8. Use `this` keyword to refer to current object field
9. **Add validation** in constructor
10. Static constructor runs **only once**
11. Parent constructor runs **before child constructor**
12. If no constructor defined, compiler creates default one
13. Each constructor should **initialize all fields**
14. Use meaningful parameter names
15. Constructor **cannot be inherited** (must be redefined)

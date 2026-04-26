# POLYMORPHISM - EXAM NOTES 📚

## What is Polymorphism?

Polymorphism means **"many forms"** (poly = many, morph = form). It's the ability of an object to take multiple forms or a method to behave differently in different contexts.

### Simple Example:
- The word **"BANK"** has different meanings:
  - Bank as in "River Bank" (geographical)
  - Bank as in "Money Bank" (financial)
  - Same word, different meanings = Polymorphism!

---

## Why Do We Need Polymorphism?

1. **Flexibility** - Same method name, different behavior
2. **Code Reusability** - Write generic code that works with multiple types
3. **Easy to Use** - Easy to remember one method name instead of many
4. **Loose Coupling** - Don't depend on concrete classes, use base class/interface
5. **Easy to Extend** - Add new functionality without changing existing code

---

## Types of Polymorphism

### Type 1: Compile-Time Polymorphism (Static Polymorphism)

Decisions are made at **COMPILE TIME** (when you write the code).

#### Method Overloading

**Same method name, different parameters** in the same class.

```csharp
class Calculator
{
    // Method 1: Add two numbers
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    // Method 2: Add three numbers (same name, different parameters)
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    
    // Method 3: Add two doubles (same name, different parameter types)
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        Console.WriteLine(calc.Add(5, 10));           // Method 1: Output: 15
        Console.WriteLine(calc.Add(5, 10, 15));       // Method 2: Output: 30
        Console.WriteLine(calc.Add(5.5, 10.5));       // Method 3: Output: 16
    }
}
```

**Output:**
```
15
30
16
```

##### How Method Overloading Works?

The compiler decides which method to call based on:
1. **Number of parameters**
2. **Type of parameters**
3. **Order of parameters**

```csharp
class Example
{
    public void Method(int a, string b) { }  // Method A
    public void Method(string a, int b) { }  // Method B
}

// These are different because ORDER of parameters is different!
Example ex = new Example();
ex.Method(5, "hello");        // Calls Method A
ex.Method("hello", 5);        // Calls Method B
```

---

#### Operator Overloading

**Redefine how operators work** with custom classes.

```csharp
class Complex
{
    public int Real, Imaginary;
    
    public Complex(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }
    
    // Overload + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
    
    // Overload - operator
    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }
    
    public void Display()
    {
        Console.WriteLine($"{Real} + {Imaginary}i");
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(3, 4);
        Complex c2 = new Complex(1, 2);
        
        Complex sum = c1 + c2;        // Uses overloaded + operator
        Complex difference = c1 - c2; // Uses overloaded - operator
        
        sum.Display();        // Output: 4 + 6i
        difference.Display(); // Output: 2 + 2i
    }
}
```

**Output:**
```
4 + 6i
2 + 2i
```

---

### Type 2: Runtime Polymorphism (Dynamic Polymorphism)

Decisions are made at **RUNTIME** (when the program is running).

#### Method Overriding

**Child class redefines a parent class method** using `override` keyword.

```csharp
class Animal
{
    public virtual void MakeSound()  // Mark as virtual
    {
        Console.WriteLine("Some sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()  // Override the method
    {
        Console.WriteLine("Woof woof");
    }
}

class Cat : Animal
{
    public override void MakeSound()  // Override the method
    {
        Console.WriteLine("Meow meow");
    }
}

class Program
{
    static void Main()
    {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();
        
        animal1.MakeSound();  // Output: Woof woof (Dog's version)
        animal2.MakeSound();  // Output: Meow meow (Cat's version)
    }
}
```

**Output:**
```
Woof woof
Meow meow
```

**Important:** The actual method called is decided at RUNTIME based on the actual object type, not the reference type!

```csharp
Animal animal = new Dog();  // Reference type: Animal
                             // Actual type: Dog

animal.MakeSound();  // Calls Dog's MakeSound(), not Animal's
                     // Decision made at RUNTIME!
```

---

## How Override Works?

### Step 1: Mark parent method as `virtual`
```csharp
public virtual void Method() { }
```

### Step 2: Override in child class
```csharp
public override void Method() { }
```

### Example:
```csharp
class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("Parent Display");
    }
}

class Child : Parent
{
    public override void Display()
    {
        Console.WriteLine("Child Display");
    }
}

class Program
{
    static void Main()
    {
        Parent p = new Child();
        p.Display();  // Output: Child Display (Runtime decision!)
    }
}
```

---

## Real-World Example: Employee Bonus Calculation

```csharp
// Base class
abstract class Employee
{
    public string name;
    public double salary;
    
    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    
    // Virtual method - can be overridden
    public virtual double CalculateBonus()
    {
        return salary * 0.10;  // 10% default bonus
    }
    
    public void DisplayBonus()
    {
        Console.WriteLine($"{name} Bonus: {CalculateBonus()}");
    }
}

// Manager class
class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary) { }
    
    public override double CalculateBonus()
    {
        return salary * 0.20;  // 20% bonus for managers
    }
}

// Developer class
class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary) { }
    
    public override double CalculateBonus()
    {
        return salary * 0.15;  // 15% bonus for developers
    }
}

// CEO class
class CEO : Employee
{
    public CEO(string name, double salary) : base(name, salary) { }
    
    public override double CalculateBonus()
    {
        return salary * 0.30;  // 30% bonus for CEO
    }
}

class Program
{
    static void Main()
    {
        // Create different types of employees
        List<Employee> employees = new List<Employee>
        {
            new Manager("Rajesh", 50000),
            new Developer("Priya", 40000),
            new CEO("Sharma", 100000)
        };
        
        // Display bonus for all employees
        foreach (Employee emp in employees)
        {
            emp.DisplayBonus();  // Each calls its own CalculateBonus()
        }
    }
}
```

**Output:**
```
Rajesh Bonus: 10000
Priya Bonus: 6000
Sharma Bonus: 30000
```

---

## Compile-Time vs Runtime Polymorphism

| Feature | Compile-Time | Runtime |
|---------|---|---|
| When decided | At compilation (write time) | At execution (run time) |
| How achieved | Method/Operator Overloading | Method Overriding |
| Performance | Faster (no lookup needed) | Slightly slower |
| Example | `Add(5, 10)` vs `Add(5.5, 10.5)` | `Dog` sound vs `Cat` sound |
| Keywords | No special keyword needed | Uses `virtual` and `override` |

---

## Important Points

### ❌ Common Mistakes:

**Mistake 1:** Forget `virtual` keyword in parent class
```csharp
class Parent
{
    public void Method() { }  // ❌ Not marked virtual
}

class Child : Parent
{
    public override void Method() { }  // ❌ ERROR: Cannot override
}
```

**Mistake 2:** Use wrong reference type
```csharp
Dog dog = new Dog();
dog.MakeSound();  // Calls Dog's version - NO polymorphism here

// This is polymorphism:
Animal animal = new Dog();  // Parent reference, Child object
animal.MakeSound();  // Calls Dog's version at RUNTIME
```

**Mistake 3:** Forget `override` keyword in child
```csharp
class Parent
{
    public virtual void Method() { }
}

class Child : Parent
{
    public void Method() { }  // ❌ This is HIDING, not OVERRIDING!
    
    public override void Method() { }  // ✅ Correct
}
```

---

## Benefits of Polymorphism

### Benefit 1: Code Reusability
```csharp
void PrintBonusForAll(List<Employee> employees)
{
    foreach (Employee emp in employees)
    {
        Console.WriteLine(emp.CalculateBonus());
    }
}
```

This works for ANY employee type - past, present, or future!

### Benefit 2: Easy to Extend
```csharp
// Add new employee type without changing existing code
class Intern : Employee
{
    public override double CalculateBonus()
    {
        return salary * 0.05;  // 5% bonus
    }
}
```

### Benefit 3: Loose Coupling
```csharp
// Code depends on base class, not concrete classes
void Process(Employee emp)
{
    emp.DisplayBonus();  // Works with ANY employee type
}
```

---

## Important Exam Questions

**Q1. What is polymorphism?**
- A: Ability of an object to take multiple forms or a method to behave differently in different contexts.

**Q2. What are the two types of polymorphism?**
- A: Compile-time (Method/Operator Overloading) and Runtime (Method Overriding).

**Q3. What is method overloading?**
- A: Same method name with different parameters in the same class.

**Q4. What is method overriding?**
- A: Child class redefining a parent class method marked as virtual.

**Q5. What keywords are used for overriding?**
- A: `virtual` in parent class, `override` in child class.

**Q6. What's the difference between overloading and overriding?**
- A: Overloading is compile-time (same class), overriding is runtime (different classes in hierarchy).

**Q7. Can we override a private method?**
- A: No, private methods cannot be overridden.

---

## Summary Points to Remember ✨

1. Polymorphism = "Many Forms"
2. **Two Types**: Compile-Time and Runtime
3. **Compile-Time**: Method/Operator Overloading (same class)
4. **Runtime**: Method Overriding (parent-child hierarchy)
5. Overloading: Same name, different parameters
6. Overriding: Child redefines parent's virtual method
7. Mark parent method with `virtual` keyword
8. Mark child method with `override` keyword
9. Actual method called is decided at RUNTIME based on object type
10. Don't use wrong reference type - use parent reference with child object for polymorphism
11. Polymorphism enables code reusability and flexibility
12. Can override abstract methods and virtual methods, not private methods

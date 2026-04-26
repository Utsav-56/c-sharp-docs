# ABSTRACTION - EXAM NOTES 📚

## What is Abstraction?

Abstraction is one of the 4 pillars of Object-Oriented Programming (OOP). It means **hiding complex details and showing only the important features to the user**.

### Simple Example:
When you use a **Mobile Phone**, you just press buttons and see results. You don't need to know how the circuits work inside. The phone **abstracts** (hides) the internal complexity from you.

---

## Why Do We Need Abstraction?

1. **Simplicity** - Users don't need to understand everything
2. **Security** - Internal details are protected from being misused
3. **Easy to Maintain** - We can change internal details without affecting external code
4. **Flexibility** - We can change implementation without changing interface

---

## How to Achieve Abstraction in C#?

### Method 1: Abstract Classes

An **abstract class** is a class that **cannot be instantiated** (we cannot create an object of it directly).

#### Syntax:
```csharp
abstract class ClassName
{
    public abstract void MethodName(); // abstract method (no body)
    public void AnotherMethod() { } // normal method (with body)
}
```

#### Key Points:
- Use `abstract` keyword to declare an abstract class
- Abstract class can have **abstract methods** (no implementation) AND **normal methods** (with implementation)
- Cannot create object: ❌ `new ClassName()` - ERROR
- Must inherit: ✅ `class Child : Parent { }`
- Child class **MUST implement** all abstract methods

#### Example:
```csharp
abstract class Shape
{
    // Abstract method - child class must implement it
    public abstract double Area();
    
    // Normal method - child class can use it as is
    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
}

class Rectangle : Shape
{
    public double length = 5;
    public double width = 4;
    
    // MUST implement the abstract method
    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        // ❌ Cannot do this: new Shape(); - ERROR
        
        // ✅ Can do this:
        Shape s = new Rectangle();
        Console.WriteLine("Area: " + s.Area()); // Output: 20
    }
}
```

---

### Method 2: Interfaces

An **interface** is like a **contract** that defines what methods a class should have. It's similar to an abstract class but even more abstract.

#### Syntax:
```csharp
interface IInterfaceName
{
    void MethodName(); // only declaration, no implementation
}
```

#### Key Points:
- Use `interface` keyword (by convention, interface names start with 'I')
- Interfaces can **ONLY declare methods**, no implementation
- Cannot create object: ❌ `new IInterface()` - ERROR
- Implement interface: `class MyClass : IInterface { }`
- Class **MUST implement** all interface methods
- **A class can implement MULTIPLE interfaces** (this is like multiple inheritance)

#### Example:
```csharp
interface IShape
{
    double Area();
}

interface IDisplayable
{
    void Display();
}

// Implementing multiple interfaces
class Rectangle : IShape, IDisplayable
{
    public double length = 5;
    public double width = 4;
    
    public double Area()
    {
        return length * width;
    }
    
    public void Display()
    {
        Console.WriteLine("Rectangle");
    }
}

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        Console.WriteLine("Area: " + r.Area()); // Output: 20
        r.Display(); // Output: Rectangle
    }
}
```

---

## Abstract Class vs Interface

| Feature | Abstract Class | Interface |
|---------|---|---|
| Can have constructor | ✅ Yes | ❌ No |
| Can have variables | ✅ Yes | ❌ No (only constants) |
| Multiple inheritance | ❌ No | ✅ Yes |
| Access modifiers | ✅ Public/Private | ❌ Always Public |
| Can have complete methods | ✅ Yes | ❌ No (only methods to declare) |
| Speed | ⚡ Faster | ⚡⚡ Slightly slower |

---

## Real-World Example

```csharp
// Abstract class for all vehicles
abstract class Vehicle
{
    public abstract void Start();
    public abstract void Stop();
    
    public void Honk()
    {
        Console.WriteLine("Horn sound");
    }
}

// Every car must implement Start() and Stop()
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car engine starts");
    }
    
    public override void Stop()
    {
        Console.WriteLine("Car engine stops");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Start();  // Output: Car engine starts
        car.Honk();   // Output: Horn sound
        car.Stop();   // Output: Car engine stops
    }
}
```

---

## Important Questions for Exam

**Q1. Can we create an object of an abstract class?**
- A: No, abstract classes cannot be instantiated directly.

**Q2. What must a child class do if the parent is abstract?**
- A: It must implement (override) all abstract methods.

**Q3. What's the difference between abstract method and normal method?**
- A: Abstract method has no body, normal method has complete implementation.

**Q4. How does C# support multiple inheritance?**
- A: Through interfaces. A class can implement multiple interfaces.

**Q5. Why use abstraction?**
- A: To hide complexity, improve security, and make code easier to maintain.

---

## Summary Points to Remember ✨

1. Abstraction = **Hide details, Show only what's needed**
2. Abstract classes = **Partial abstraction** (can have normal + abstract methods)
3. Interfaces = **Complete abstraction** (only method declarations)
4. Child class **MUST** implement all abstract methods
5. Cannot create object of abstract class directly
6. Use `override` keyword when implementing abstract methods
7. Interface is preferred when you want multiple inheritance
8. Abstract class is preferred when you want to share code among related classes

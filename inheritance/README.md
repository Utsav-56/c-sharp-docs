# INHERITANCE - EXAM NOTES 📚

## What is Inheritance?

Inheritance is a mechanism that allows a class to **inherit properties and methods from another class**. It's like a child inheriting traits from their parents!

### Real-Life Example:
- **Parent:** Animal (properties: age, weight, methods: eat(), sleep())
- **Child:** Dog (inherits from Animal, adds methods: bark())

---

## Why Do We Need Inheritance?

1. **Code Reuse** - Don't repeat code, inherit from parent class
2. **Logical Organization** - Create hierarchy of classes
3. **Easier Maintenance** - Change parent once, affects all children
4. **Polymorphism** - Write flexible code using parent class reference

---

## Terminology

| Term | Meaning |
|------|---------|
| **Parent Class (Base Class)** | The class being inherited from |
| **Child Class (Derived Class)** | The class that inherits from parent |
| **Inheritance** | The process of deriving properties from parent |

---

## How to Create Inheritance in C#?

### Syntax:
```csharp
class Parent
{
    // parent class members
}

class Child : Parent // Notice the colon (:)
{
    // child class members
}
```

**Important:** C# uses **colon (:)** for inheritance, NOT `extends` like Java!

---

## Types of Inheritance

### Type 1: Single Inheritance
One class inherits from **one parent class**.

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();   // From Animal
        dog.Bark();  // From Dog
    }
}
```

**Output:**
```
Animal eats
Dog barks
```

---

### Type 2: Multilevel Inheritance
Class A ← Class B ← Class C (Grandparent → Parent → Child)

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class Mammal : Animal
{
    public void WalkOnLegs()
    {
        Console.WriteLine("Walking on legs");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();          // From Animal
        dog.WalkOnLegs();   // From Mammal
        dog.Bark();         // From Dog
    }
}
```

**Output:**
```
Eating
Walking on legs
Barking
```

---

### Type 3: Hierarchical Inheritance
Multiple classes inherit from **one parent class**.

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();   // From Animal
        dog.Bark();  // From Dog
        
        Cat cat = new Cat();
        cat.Eat();   // From Animal
        cat.Meow();  // From Cat
    }
}
```

**Output:**
```
Eating
Barking
Eating
Meowing
```

---

### Type 4: Multiple Inheritance ⚠️
**C# does NOT support multiple inheritance with classes** (to avoid ambiguity), but it can be achieved using **Interfaces**.

```csharp
// ❌ This is NOT possible in C#:
// class Dog : Animal, Bird { }

// ✅ But this IS possible with interfaces:
interface IAnimal { }
interface IBird { }

class Dog : IAnimal, IBird { }
```

---

## Important Keywords in Inheritance

### Keyword 1: `base`
Used to access parent class members from child class.

```csharp
class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public void MakeSound()
    {
        base.MakeSound();  // Calls parent's MakeSound()
        Console.WriteLine("Woof woof");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound();
    }
}
```

**Output:**
```
Animal sound
Woof woof
```

---

### Keyword 2: `virtual` and `override`
Used for method overriding (method redefinition in child class).

```csharp
class Animal
{
    public virtual void MakeSound()  // Mark as virtual
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()  // Override the method
    {
        Console.WriteLine("Woof woof");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog();
        animal.MakeSound();  // Output: Woof woof
    }
}
```

**Output:**
```
Woof woof
```

**Important:** WITHOUT `virtual` keyword in parent, you CANNOT override in child class!

---

### Keyword 3: `protected`
Access modifier that allows access in parent and child classes only.

```csharp
class Animal
{
    protected string name = "Animal";
}

class Dog : Animal
{
    public void ShowName()
    {
        Console.WriteLine(name);  // Can access protected member
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.ShowName();  // Output: Animal
        // dog.name = "x"; // ❌ ERROR: Cannot access outside class hierarchy
    }
}
```

---

## Constructor in Inheritance

When creating a child class object, parent constructor is called first.

```csharp
class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor");
    }
}

class Dog : Animal
{
    public Dog() : base()  // Call parent constructor
    {
        Console.WriteLine("Dog constructor");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
    }
}
```

**Output:**
```
Animal constructor
Dog constructor
```

---

## Passing Parameters to Parent Constructor

```csharp
class Animal
{
    public string name;
    
    public Animal(string name)
    {
        this.name = name;
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine("Dog created with name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Buddy");
    }
}
```

**Output:**
```
Dog created with name: Buddy
```

---

## Access Levels in Inheritance

| Access Modifier | Child Class Can Access? | Outside Class Can Access? |
|---|---|---|
| `public` | ✅ Yes | ✅ Yes |
| `protected` | ✅ Yes | ❌ No |
| `private` | ❌ No | ❌ No |
| `internal` | ✅ Yes (same assembly) | ✅ Yes (same assembly) |

---

## Real-World Example

```csharp
// Parent class
abstract class Employee
{
    protected string name;
    protected double salary;
    
    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    
    public virtual double CalculateBonus()
    {
        return salary * 0.1;  // 10% bonus
    }
}

// Child class
class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary)
    {
    }
    
    public override double CalculateBonus()
    {
        return salary * 0.2;  // 20% bonus for managers
    }
}

// Child class
class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary)
    {
    }
    
    public override double CalculateBonus()
    {
        return salary * 0.15;  // 15% bonus for developers
    }
}

class Program
{
    static void Main()
    {
        Employee manager = new Manager("John", 50000);
        Employee developer = new Developer("Jane", 40000);
        
        Console.WriteLine("Manager bonus: " + manager.CalculateBonus());      // 10000
        Console.WriteLine("Developer bonus: " + developer.CalculateBonus());  // 6000
    }
}
```

---

## Important Exam Questions

**Q1. What is inheritance?**
- A: It's a mechanism to inherit properties and methods from one class to another.

**Q2. What keyword is used for inheritance in C#?**
- A: Colon (:), e.g., `class Child : Parent`

**Q3. Difference between `virtual` and `override`?**
- A: `virtual` in parent marks method as overridable, `override` in child actually overrides it.

**Q4. What is `base` keyword?**
- A: It's used to access parent class members from child class.

**Q5. Can child class access private members of parent?**
- A: No, only public and protected members.

**Q6. What is multilevel inheritance?**
- A: When a class inherits from a parent, which itself inherits from another parent.

**Q7. Does C# support multiple inheritance?**
- A: No with classes, but yes with interfaces.

---

## Summary Points to Remember ✨

1. Inheritance = Inheriting properties and methods from parent class
2. C# uses **colon (:)** for inheritance
3. **4 Types:** Single, Multilevel, Hierarchical, Multiple (with interfaces)
4. Parent constructor is called BEFORE child constructor
5. Use `virtual` in parent, `override` in child for method overriding
6. Use `base` to access parent members
7. Use `protected` to make members accessible to child classes
8. Multiple inheritance is only possible with interfaces, not classes
9. Don't forget `base()` call in child constructor to initialize parent
10. Child can add new members and override parent's virtual methods

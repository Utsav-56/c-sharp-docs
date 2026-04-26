# GENERIC TYPES AND NAMESPACE - EXAM NOTES 📚

## What is a Generic Type?

A **generic type** is a **class, interface, or method** that works with **any data type**. It allows you to write **flexible, reusable code**.

### Without Generics (Problem):
```csharp
// Only works with int
class Stack
{
    private int[] items;
    
    public void Push(int item) { }
    public int Pop() { }
}

// Need different class for string
class StringStack
{
    private string[] items;
    
    public void Push(string item) { }
    public string Pop() { }
}
```

**Problem:** Code duplication, not flexible!

### With Generics (Solution):
```csharp
// Works with ANY type
class Stack<T>  // T = any type
{
    private T[] items;
    
    public void Push(T item) { }
    public T Pop() { }
}

// Use with int
Stack<int> intStack = new Stack<int>();

// Use with string
Stack<string> stringStack = new Stack<string>();
```

**Benefit:** One class, works with any type!

---

## Declaring Generic Types

### Generic Class

```csharp
class Container<T>  // T is type parameter
{
    private T item;
    
    public void Add(T value)
    {
        item = value;
    }
    
    public T Get()
    {
        return item;
    }
}

class Program
{
    static void Main()
    {
        // Use with int
        Container<int> intContainer = new Container<int>();
        intContainer.Add(42);
        Console.WriteLine(intContainer.Get());  // Output: 42
        
        // Use with string
        Container<string> stringContainer = new Container<string>();
        stringContainer.Add("Hello");
        Console.WriteLine(stringContainer.Get());  // Output: Hello
    }
}
```

---

### Generic Method

```csharp
class Printer
{
    // Generic method
    public void Print<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
        Console.WriteLine($"Type: {typeof(T).Name}");
    }
}

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        printer.Print<int>(42);        // Output: Value: 42, Type: Int32
        printer.Print<string>("Hello"); // Output: Value: Hello, Type: String
    }
}
```

---

### Generic Interface

```csharp
interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
    void Remove(int id);
}

class UserRepository : IRepository<string>
{
    public void Add(string user) { }
    public string Get(int id) { return "User"; }
    public void Remove(int id) { }
}
```

---

## Constraints on Generic Types

Limit what types can be used as type parameter.

### Constraint 1: Class Constraint
Only reference types (classes).

```csharp
class Repository<T> where T : class
{
    public void Display(T item)
    {
        Console.WriteLine(item);
    }
}

// Valid
Repository<string> repo1 = new Repository<string>();

// Invalid - int is value type
// Repository<int> repo2 = new Repository<int>();  // ERROR
```

---

### Constraint 2: Struct Constraint
Only value types (structs).

```csharp
class GenericClass<T> where T : struct
{
    public void Display(T item)
    {
        Console.WriteLine(item);
    }
}

// Valid
GenericClass<int> gc1 = new GenericClass<int>();

// Invalid - string is reference type
// GenericClass<string> gc2 = new GenericClass<string>();  // ERROR
```

---

### Constraint 3: New Constraint
Must have parameterless constructor.

```csharp
class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();  // Only works if T has parameterless constructor
    }
}

class Product
{
    public Product() { }  // Has parameterless constructor
}

class Program
{
    static void Main()
    {
        Factory<Product> factory = new Factory<Product>();
        Product product = factory.Create();
    }
}
```

---

### Constraint 4: Base Class Constraint
Must inherit from specific class.

```csharp
class Repository<T> where T : Animal
{
    public void Process(T item)
    {
        item.MakeSound();
    }
}

class Animal
{
    public virtual void MakeSound() { }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        Repository<Dog> repo = new Repository<Dog>();
        repo.Process(new Dog());  // Output: Woof!
    }
}
```

---

### Constraint 5: Interface Constraint
Must implement specific interface.

```csharp
class Sorter<T> where T : IComparable
{
    public void Sort(T[] items) { }
}

class Program
{
    static void Main()
    {
        // Valid - string implements IComparable
        Sorter<string> sorter = new Sorter<string>();
    }
}
```

---

## What is a Namespace?

A **namespace** is a **container for classes** and other types to **organize code** and **avoid naming conflicts**.

### Problem Without Namespaces:
```csharp
// Two different Student classes?
class Student { }  // From your project
class Student { }  // From library
// ERROR: Duplicate class name!
```

### Solution With Namespaces:
```csharp
namespace MyProject
{
    class Student { }
}

namespace LibraryProject
{
    class Student { }
}

// Now both can exist!
MyProject.Student s1 = new MyProject.Student();
LibraryProject.Student s2 = new LibraryProject.Student();
```

---

## Creating and Using Namespaces

### Declaring Namespace

```csharp
namespace MyApplication.Models
{
    class Student
    {
        public string name;
    }
}
```

---

### Using Namespace

```csharp
using MyApplication.Models;  // Import namespace

class Program
{
    static void Main()
    {
        Student s = new Student();  // No need to write full name
    }
}
```

---

### Nested Namespaces

```csharp
namespace MyApplication
{
    namespace Models
    {
        class Student { }
    }
    
    namespace Services
    {
        class StudentService { }
    }
}

// Usage
MyApplication.Models.Student s = new MyApplication.Models.Student();
MyApplication.Services.StudentService service = new MyApplication.Services.StudentService();
```

---

## Common Built-in Namespaces

| Namespace | Purpose | Examples |
|-----------|---------|----------|
| `System` | Core types | Console, String, Int32 |
| `System.Collections` | Collections | ArrayList, Hashtable |
| `System.Collections.Generic` | Generic collections | List<T>, Dictionary<K,V> |
| `System.Linq` | Language Integrated Query | Query collections |
| `System.Text` | String building | StringBuilder |
| `System.IO` | File and stream operations | File, Stream |

---

## Example: Complete Program with Namespace and Generics

```csharp
using System;
using System.Collections.Generic;

// Define namespace
namespace StudentManagement
{
    // Generic repository
    class Repository<T> where T : class, new()
    {
        private List<T> items = new List<T>();
        
        public void Add(T item)
        {
            items.Add(item);
        }
        
        public List<T> GetAll()
        {
            return items;
        }
    }
    
    // Student class
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        
        public Student() { }
        
        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }
        
        public override string ToString()
        {
            return $"{Name} - {Age} - {GPA}";
        }
    }
    
    // Main program
    class Program
    {
        static void Main()
        {
            Repository<Student> repo = new Repository<Student>();
            
            repo.Add(new Student("Rajesh", 22, 3.8));
            repo.Add(new Student("Priya", 21, 3.9));
            repo.Add(new Student("Amit", 22, 3.5));
            
            foreach (var student in repo.GetAll())
            {
                Console.WriteLine(student);
            }
        }
    }
}
```

**Output:**
```
Rajesh - 22 - 3.8
Priya - 21 - 3.9
Amit - 22 - 3.5
```

---

## Important Exam Questions

**Q1. What are generics?**
- A: Classes/methods that work with any data type using type parameters.

**Q2. What is `<T>`?**
- A: Type parameter, placeholder for any type.

**Q3. Why use generics?**
- A: For code reusability, type safety, and flexibility.

**Q4. What is a constraint?**
- A: Limits what types can be used as type parameter.

**Q5. What is a namespace?**
- A: Container for organizing classes and avoiding naming conflicts.

**Q6. How to avoid naming conflicts?**
- A: Use namespaces to organize classes.

---

## Summary Points to Remember ✨

1. Generics = classes/methods working with any type
2. `<T>` = type parameter (can be any name: K, V, U, etc.)
3. Benefits: Reusability, type safety, flexibility
4. Constraints limit what types can be used
5. Common constraints: class, struct, new(), base class, interface
6. Namespace = container for organizing code
7. Use `using` to import namespace
8. Avoid naming conflicts with namespaces
9. `System` namespace has core types
10. `System.Collections.Generic` has generic collections
11. Multiple constraints possible: `where T : class, new()`
12. Built-in generic types: `List<T>`, `Dictionary<K,V>`, etc.
13. Custom generic types improve code reusability
14. Namespace hierarchy uses dot notation
15. One class per namespace recommended for clarity

# BASICS - EXAM NOTES 📚

## What is C#?

C# (C-Sharp) is a modern, object-oriented programming language created by **Microsoft**. It's used to build:
- **Desktop applications** (Windows Forms, WPF)
- **Web applications** (ASP.NET)
- **Mobile applications** (Xamarin)
- **Games** (Unity)

---

## Why Learn C#?

1. **Easy to Learn** - Simple, clear syntax
2. **Object-Oriented** - Good for building large projects
3. **Powerful** - Can build professional applications
4. **Popular** - Used in industry, games, web
5. **Safe** - Built-in error handling

---

## Your First C# Program

### Structure:

```csharp
using System;  // Import System namespace

class Program  // Define a class
{
    static void Main()  // Entry point (where program starts)
    {
        Console.WriteLine("Hello, World!");  // Print to console
    }
}
```

**Output:**
```
Hello, World!
```

---

## Basic Concepts

### 1. Variables

A variable is a **container** that stores data.

#### Declaring a Variable:
```csharp
dataType variableName = value;
```

#### Examples:
```csharp
int age = 25;           // Integer
double height = 5.9;    // Decimal number
string name = "John";   // Text
bool isStudent = true;  // True/False
char grade = 'A';       // Single character
```

#### Naming Rules:
- Start with letter or underscore: `_age`, `age1`
- Cannot start with number: ❌ `1age`
- No spaces: ❌ `my age`, ✅ `myAge`
- Case-sensitive: `age` and `Age` are different

---

### 2. Input and Output

#### Output (Printing to Console)

```csharp
Console.WriteLine("Hello");        // Prints and moves to new line
Console.Write("Hello");            // Prints on same line
Console.WriteLine("Sum: " + 5);    // Print with concatenation
```

#### Input (Taking from User)

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();  // Read entire line as text

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());  // Read and convert to int

Console.WriteLine("Hello " + name + ", you are " + age + " years old");
```

#### Example:
```csharp
class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Hello " + name);
        Console.WriteLine("You are " + age + " years old");
    }
}
```

**Input:**
```
Enter your name: Rajesh
Enter your age: 22
```

**Output:**
```
Hello Rajesh
You are 22 years old
```

---

### 3. String Interpolation (Modern Way)

Instead of concatenation, use `$` for cleaner code:

```csharp
string name = "Rajesh";
int age = 22;

// Old way (concatenation):
Console.WriteLine("Hello " + name + ", you are " + age + " years old");

// New way (interpolation):
Console.WriteLine($"Hello {name}, you are {age} years old");
```

Both produce same output:
```
Hello Rajesh, you are 22 years old
```

---

## Operators

### Arithmetic Operators

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `+` | Addition | `10 + 5` | 15 |
| `-` | Subtraction | `10 - 5` | 5 |
| `*` | Multiplication | `10 * 5` | 50 |
| `/` | Division | `10 / 5` | 2 |
| `%` | Modulus (remainder) | `10 % 3` | 1 |
| `++` | Increment | `a++` | Adds 1 |
| `--` | Decrement | `a--` | Subtracts 1 |

```csharp
int a = 10, b = 5;

Console.WriteLine(a + b);  // Output: 15
Console.WriteLine(a - b);  // Output: 5
Console.WriteLine(a * b);  // Output: 50
Console.WriteLine(a / b);  // Output: 2
Console.WriteLine(a % b);  // Output: 0
```

---

### Comparison Operators

| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `==` | Equal to | `5 == 5` | true |
| `!=` | Not equal to | `5 != 3` | true |
| `>` | Greater than | `5 > 3` | true |
| `<` | Less than | `5 < 3` | false |
| `>=` | Greater than or equal to | `5 >= 5` | true |
| `<=` | Less than or equal to | `5 <= 3` | false |

```csharp
int x = 10, y = 5;

Console.WriteLine(x == y);  // false
Console.WriteLine(x > y);   // true
Console.WriteLine(x <= y);  // false
```

---

### Logical Operators

| Operator | Name | Example | Meaning |
|----------|------|---------|---------|
| `&&` | AND | `(x > 5) && (y < 10)` | Both must be true |
| `\|\|` | OR | `(x > 5) \|\| (y < 10)` | At least one must be true |
| `!` | NOT | `!(x > 5)` | Reverses the result |

```csharp
bool a = true, b = false;

Console.WriteLine(a && b);   // false (both not true)
Console.WriteLine(a || b);   // true (at least one true)
Console.WriteLine(!a);       // false (reverses true)
```

---

## Control Flow

### If-Else Statement

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are adult");
}
else
{
    Console.WriteLine("You are minor");
}
```

### If-Else If-Else

```csharp
int marks = 75;

if (marks >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (marks >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}
```

### Switch Statement

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Other day");
        break;
}
```

**Output:** `Wednesday`

---

## Loops

### While Loop

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

**Output:**
```
1
2
3
4
5
```

---

### For Loop

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

**Output:**
```
1
2
3
4
5
```

---

### Do-While Loop

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
```

---

### Foreach Loop (For Collections)

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

**Output:**
```
10
20
30
40
50
```

---

## Methods (Functions)

A method is a **block of code** that performs a specific task.

### Syntax:
```csharp
returnType MethodName(parameters)
{
    // Code here
    return value;  // (if returnType is not void)
}
```

### Example 1: Method with No Return
```csharp
void Greet(string name)
{
    Console.WriteLine("Hello, " + name);
}

// Call the method
Greet("Rajesh");  // Output: Hello, Rajesh
```

### Example 2: Method with Return
```csharp
int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}

// Call the method
int result = Add(5, 10);
Console.WriteLine(result);  // Output: 15
```

### Example 3: Multiple Parameters
```csharp
void PrintStudentInfo(string name, int age, double gpa)
{
    Console.WriteLine($"Name: {name}, Age: {age}, GPA: {gpa}");
}

// Call the method
PrintStudentInfo("Rajesh", 22, 3.8);
```

---

## Classes and Objects

### Creating a Class

```csharp
class Student
{
    // Fields (variables)
    public string name;
    public int age;
    public double gpa;
    
    // Method
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, GPA: {gpa}");
    }
}
```

### Creating an Object

```csharp
class Program
{
    static void Main()
    {
        // Create an object of Student class
        Student student1 = new Student();
        
        // Set values
        student1.name = "Rajesh";
        student1.age = 22;
        student1.gpa = 3.8;
        
        // Call method
        student1.Display();  // Output: Name: Rajesh, Age: 22, GPA: 3.8
        
        // Create another object
        Student student2 = new Student();
        student2.name = "Priya";
        student2.age = 21;
        student2.gpa = 3.9;
        
        student2.Display();  // Output: Name: Priya, Age: 21, GPA: 3.9
    }
}
```

---

### Constructors

A constructor is a **special method** that runs when an object is created.

```csharp
class Student
{
    public string name;
    public int age;
    
    // Constructor
    public Student(string n, int a)
    {
        name = n;
        age = a;
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
        // Constructor is automatically called
        Student s = new Student("Rajesh", 22);
        s.Display();  // Output: Name: Rajesh, Age: 22
    }
}
```

---

## Properties (Getter and Setter)

Properties provide a safe way to access and modify private data.

```csharp
class Person
{
    private int _age;  // Private (hidden)
    
    // Property with getter and setter
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
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = 25;              // Uses setter
        Console.WriteLine(p.Age);  // Uses getter, Output: 25
        
        p.Age = -5;              // Output: Invalid age! (validation)
    }
}
```

---

## Real-World Example: Student Management

```csharp
class Student
{
    public string name;
    public int rollNumber;
    public double gpa;
    
    // Constructor
    public Student(string name, int rollNumber, double gpa)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.gpa = gpa;
    }
    
    // Method
    public void Display()
    {
        Console.WriteLine($"Roll: {rollNumber}, Name: {name}, GPA: {gpa}");
    }
    
    // Method
    public bool IsPassing()
    {
        return gpa >= 2.0;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];
        
        students[0] = new Student("Rajesh", 101, 3.8);
        students[1] = new Student("Priya", 102, 3.5);
        students[2] = new Student("Amit", 103, 1.8);
        
        foreach (Student s in students)
        {
            s.Display();
            Console.WriteLine("Passing: " + s.IsPassing());
            Console.WriteLine();
        }
    }
}
```

**Output:**
```
Roll: 101, Name: Rajesh, GPA: 3.8
Passing: True

Roll: 102, Name: Priya, GPA: 3.5
Passing: True

Roll: 103, Name: Amit, GPA: 1.8
Passing: False
```

---

## Important Exam Questions

**Q1. What is C#?**
- A: A modern, object-oriented programming language created by Microsoft.

**Q2. What is a variable?**
- A: A container that stores data.

**Q3. What is a method?**
- A: A block of code that performs a specific task and can be reused.

**Q4. What is a class?**
- A: A blueprint for creating objects that defines properties and methods.

**Q5. What is an object?**
- A: An instance of a class with actual values.

**Q6. What is a constructor?**
- A: A special method that runs when an object is created.

**Q7. Difference between void and return type?**
- A: void method doesn't return anything, return type method returns a value.

---

## Summary Points to Remember ✨

1. C# is an object-oriented language
2. All code runs inside a **class**
3. **Main()** is the entry point of the program
4. **Variables** store data with specific data types
5. **Operators** perform operations (arithmetic, logical, comparison)
6. **Control flow:** if-else, switch for decisions
7. **Loops:** while, for, do-while, foreach for repetition
8. **Methods:** reusable blocks of code
9. **Classes:** blueprints for objects
10. **Objects:** instances of classes with actual values
11. **Constructors:** initialize objects when created
12. **Properties:** safe access to private data
13. Use `Console.WriteLine()` for output
14. Use `Console.ReadLine()` for input
15. Use `$` for string interpolation (modern approach)

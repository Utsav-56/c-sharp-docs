# DATA TYPES - EXAM NOTES 📚

## What are Data Types?

Data Types define **what kind of data a variable can store** and **how much memory** it needs.

Think of it like containers:
- Small container = can store small items only
- Large container = can store large items

---

## Main Categories of Data Types

### Category 1: Value Types (store actual value in memory)
### Category 2: Reference Types (store memory address/reference)

---

## Value Types in C#

### Numeric Types

#### Integer Types (Whole Numbers)

| Type | Range | Size | Example |
|------|-------|------|---------|
| `byte` | 0 to 255 | 1 byte | `byte age = 25;` |
| `sbyte` | -128 to 127 | 1 byte | `sbyte score = -50;` |
| `short` | -32,768 to 32,767 | 2 bytes | `short count = 1000;` |
| `ushort` | 0 to 65,535 | 2 bytes | `ushort value = 5000;` |
| `int` | -2,147,483,648 to 2,147,483,647 | 4 bytes | `int salary = 50000;` |
| `uint` | 0 to 4,294,967,295 | 4 bytes | `uint total = 100000;` |
| `long` | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | 8 bytes | `long bigNumber = 999999999;` |
| `ulong` | 0 to 18,446,744,073,709,551,615 | 8 bytes | `ulong huge = 999999999999;` |

**Most Common:** `int`

```csharp
int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);  // Output: 30
```

---

#### Floating-Point Types (Decimal Numbers)

| Type | Precision | Size | Example |
|------|-----------|------|---------|
| `float` | ~6-9 digits | 4 bytes | `float price = 19.99f;` |
| `double` | ~15-17 digits | 8 bytes | `double height = 5.9;` |
| `decimal` | ~28-29 digits | 16 bytes | `decimal salary = 50000.50m;` |

**Most Common:** `double`

```csharp
float pi1 = 3.14f;      // Must use 'f' suffix
double pi2 = 3.14159;   // Default for decimals
decimal price = 99.99m; // Must use 'm' suffix

Console.WriteLine(pi1);     // Output: 3.14
Console.WriteLine(pi2);     // Output: 3.14159
Console.WriteLine(price);   // Output: 99.99
```

---

#### Boolean Type

| Type | Values | Size | Example |
|------|--------|------|---------|
| `bool` | true or false | 1 byte | `bool isActive = true;` |

```csharp
bool isRaining = true;
bool isPassing = false;

if (isRaining)
    Console.WriteLine("Carry umbrella");
else
    Console.WriteLine("No umbrella needed");
```

---

#### Character Type

| Type | Range | Size | Example |
|------|-------|------|---------|
| `char` | 'A' to 'Z', 'a' to 'z', '0' to '9', symbols | 2 bytes | `char grade = 'A';` |

```csharp
char initial = 'J';
char symbol = '@';
char digit = '5';

Console.WriteLine(initial);  // Output: J
Console.WriteLine(symbol);   // Output: @
Console.WriteLine(digit);    // Output: 5
```

---

### Structured Types

#### Struct
A lightweight type that groups related data. Similar to a class but simpler.

```csharp
struct Point
{
    public int X;
    public int Y;
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Point p = new Point(10, 20);
        p.Display();  // Output: Point: (10, 20)
    }
}
```

#### Enum
A type that defines a set of named constants.

```csharp
enum Color { Red, Green, Blue }
enum Day { Monday, Tuesday, Wednesday, Thursday, Friday }

class Program
{
    static void Main()
    {
        Color myColor = Color.Red;
        Day today = Day.Monday;
        
        Console.WriteLine(myColor);  // Output: Red
        Console.WriteLine(today);    // Output: Monday
    }
}
```

---

## Reference Types in C#

Reference types store the **address of the actual data**, not the data itself.

### Class
A blueprint for creating objects.

```csharp
class Student
{
    public string name;
    public int age;
    
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();  // Create object
        s.name = "Rajesh";
        s.age = 20;
        s.Display();  // Output: Name: Rajesh, Age: 20
    }
}
```

---

### Array
A collection of elements of the same type.

```csharp
// Create an array of integers
int[] numbers = { 10, 20, 30, 40, 50 };

// Access elements
Console.WriteLine(numbers[0]);  // Output: 10
Console.WriteLine(numbers[2]);  // Output: 30

// Modify elements
numbers[1] = 25;

// Loop through array
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

---

### String
A sequence of characters.

```csharp
string name = "John Doe";
string message = "Hello, World!";

Console.WriteLine(name);           // Output: John Doe
Console.WriteLine(message);        // Output: Hello, World!
Console.WriteLine(name.Length);    // Output: 8
```

---

### Interface
A contract defining methods that a class must implement.

```csharp
interface IShape
{
    double Area();
}

class Rectangle : IShape
{
    public double length = 5;
    public double width = 4;
    
    public double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        Console.WriteLine(rect.Area());  // Output: 20
    }
}
```

---

## Value Types vs Reference Types

| Feature | Value Type | Reference Type |
|---------|---|---|
| Stores | Actual value | Memory address |
| Created | Stack | Heap |
| Assignment | Copies value | Copies reference |
| Example | int, float, bool, struct | class, array, string, interface |
| Performance | Faster | Slightly slower |
| Memory | Less | More |

### Visual Example:
```csharp
// Value Type
int a = 10;
int b = a;    // b gets copy of a's value
b = 20;
Console.WriteLine(a);  // Output: 10 (unchanged)

// Reference Type
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;     // arr2 points to same array
arr2[0] = 99;
Console.WriteLine(arr1[0]);  // Output: 99 (changed!)
```

---

## Type Conversion

### Implicit Conversion (Automatic, Safe)
```csharp
int num = 100;
double doubleNum = num;  // Automatically converts int to double
Console.WriteLine(doubleNum);  // Output: 100
```

**Safe conversions:**
- byte → short → int → long
- int → double → decimal

### Explicit Conversion (Manual, Requires Cast)
```csharp
double doubleNum = 123.45;
int num = (int)doubleNum;  // Explicit cast using (int)
Console.WriteLine(num);     // Output: 123 (decimal part lost!)
```

### String Conversion
```csharp
// Converting to string
int num = 25;
string str = num.ToString();

// Converting from string
string numStr = "50";
int parsedNum = int.Parse(numStr);

// Safe conversion
bool success = int.TryParse("100", out int result);
if (success)
    Console.WriteLine(result);
```

---

## Default Values

Every data type has a default value if not initialized:

| Type | Default Value |
|------|---|
| int | 0 |
| float | 0.0 |
| double | 0.0 |
| bool | false |
| char | '\0' (null character) |
| string | null |
| class object | null |

```csharp
int num;           // default: 0
float price;       // default: 0.0
bool isActive;     // default: false
string name;       // default: null

Console.WriteLine(num);        // Output: 0
Console.WriteLine(price);      // Output: 0
Console.WriteLine(isActive);   // Output: False
Console.WriteLine(name);       // Output: (blank/null)
```

---

## Example: Using Different Data Types

```csharp
class Student
{
    public int rollNumber;        // int: whole number
    public string name;           // string: text
    public float gpa;             // float: decimal with less precision
    public bool isPassing;        // bool: true/false
    public char grade;            // char: single character
    public DateTime dateOfBirth;  // DateTime: date and time
    
    public void Display()
    {
        Console.WriteLine($"Roll: {rollNumber}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"GPA: {gpa}");
        Console.WriteLine($"Passing: {isPassing}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"DOB: {dateOfBirth}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.rollNumber = 101;
        s.name = "Rajesh Kumar";
        s.gpa = 3.8f;
        s.isPassing = true;
        s.grade = 'A';
        s.dateOfBirth = new DateTime(2002, 5, 15);
        
        s.Display();
    }
}
```

**Output:**
```
Roll: 101
Name: Rajesh Kumar
GPA: 3.8
Passing: True
Grade: A
DOB: 5/15/2002 12:00:00 AM
```

---

## Important Exam Questions

**Q1. What are data types?**
- A: Data types define what kind of data a variable can store and how much memory it needs.

**Q2. What are value types?**
- A: Data types that store actual values directly in memory (int, float, bool, struct).

**Q3. What are reference types?**
- A: Data types that store memory address/reference to actual data (class, array, string).

**Q4. What is the difference between int and long?**
- A: int is 4 bytes (-2,147,483,648 to 2,147,483,647), long is 8 bytes (much larger range).

**Q5. When do you use float vs double?**
- A: float for less precision/memory, double for more precision (double is default).

**Q6. What's implicit vs explicit conversion?**
- A: Implicit is automatic (safe), explicit needs cast operator and may lose data.

---

## Summary Points to Remember ✨

1. **Value Types:** int, float, double, bool, char, struct - store actual value
2. **Reference Types:** class, array, string, interface - store memory address
3. **Integer:** int (most common), long (very large), byte (very small)
4. **Decimal:** double (default), float (less memory), decimal (most precise)
5. **Boolean:** bool for true/false conditions
6. **Character:** char for single character ('A', '5', etc.)
7. **String:** for text, e.g., "Hello"
8. **Array:** collection of same type elements
9. **Class:** custom data type combining multiple fields/methods
10. **Struct:** lightweight class (value type)
11. **Enum:** set of named constants
12. **Implicit conversion:** safe, automatic
13. **Explicit conversion:** use (type) cast, may lose data
14. Each type has default value (0, false, null, etc.)

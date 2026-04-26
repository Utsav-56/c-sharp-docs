# PRACTICE PROBLEMS - EXAM NOTES 📚

## Overview

This folder contains **practice problems** to test your understanding of C# concepts. These problems cover:
- Classes and Objects
- Operators (Null-Coalescing)
- Data Structures (Collections, Indexers)
- Problem-solving skills

---

## Problem-Solving Tips

### Before Writing Code:
1. **Read problem carefully** - Understand what's asked
2. **Identify inputs and outputs** - What do you need to produce?
3. **Plan the solution** - Write logic in steps
4. **Choose appropriate data types** - int, string, array, list, etc.
5. **Handle edge cases** - Empty data, negative numbers, null values

### While Writing Code:
1. **Use meaningful variable names** - `studentAge` not `a`
2. **Add comments** - Explain complex logic
3. **Test with examples** - Try different inputs
4. **Check for errors** - Compilation and runtime errors
5. **Validate input** - Ensure user input is correct

### After Writing Code:
1. **Test thoroughly** - Try various inputs
2. **Check output format** - Is it correct?
3. **Look for improvements** - Can code be simpler?
4. **Consider performance** - Is it efficient enough?

---

## Common Problem Categories

### 1. Class Definition Problems

**Example Task:** Create a class `Employee` with fields for name, salary, and methods to calculate bonus.

```csharp
class Employee
{
    public string name;
    public double salary;
    
    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    
    public double CalculateBonus()
    {
        return salary * 0.10;  // 10% bonus
    }
    
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Salary: {salary}, Bonus: {CalculateBonus()}");
    }
}
```

---

### 2. Matrix/2D Array Problems

**Example Task:** Create a matrix (2D array) and find the sum of all elements.

```csharp
class Program
{
    static int SumMatrix(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }
    
    static void Main()
    {
        int[,] matrix = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        Console.WriteLine("Sum: " + SumMatrix(matrix));  // Output: 45
    }
}
```

---

### 3. Collection Problems

**Example Task:** Create a list of students and find those with GPA > 3.5.

```csharp
class Student
{
    public string name;
    public double gpa;
    
    public Student(string name, double gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Rajesh", 3.8),
            new Student("Priya", 3.2),
            new Student("Amit", 3.9),
            new Student("Neha", 3.1)
        };
        
        foreach (Student s in students)
        {
            if (s.gpa > 3.5)
            {
                Console.WriteLine($"{s.name}: {s.gpa}");  // Output: Rajesh: 3.8, Amit: 3.9
            }
        }
    }
}
```

---

### 4. String Manipulation Problems

**Example Task:** Reverse a string.

```csharp
static string ReverseString(string str)
{
    string reversed = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        reversed += str[i];
    }
    return reversed;
}

class Program
{
    static void Main()
    {
        string text = "Hello";
        Console.WriteLine(ReverseString(text));  // Output: olleH
    }
}
```

---

### 5. Indexer Problems

**Example Task:** Create a class with indexer to access elements by index.

```csharp
class StudentCollection
{
    private string[] students = new string[10];
    
    // Indexer
    public string this[int index]
    {
        get { return students[index]; }
        set { students[index] = value; }
    }
    
    public void Display()
    {
        foreach (string s in students)
        {
            if (s != null)
                Console.WriteLine(s);
        }
    }
}

class Program
{
    static void Main()
    {
        StudentCollection collection = new StudentCollection();
        collection[0] = "Rajesh";
        collection[1] = "Priya";
        collection[2] = "Amit";
        
        collection.Display();
    }
}
```

---

## Null-Coalescing Operator (??)

The **Null-Coalescing Operator** returns the left value if it's not null, otherwise returns the right value.

### Syntax:
```csharp
value ?? defaultValue
```

### Example 1: Simple Usage
```csharp
string name = null;
string result = name ?? "Unknown";
Console.WriteLine(result);  // Output: Unknown
```

### Example 2: With Variables
```csharp
string? name = null;
string? city = "Kathmandu";

Console.WriteLine(name ?? "No Name");        // Output: No Name
Console.WriteLine(city ?? "No City");        // Output: Kathmandu
```

### Example 3: Chaining
```csharp
string? first = null;
string? second = null;
string? third = "Rajesh";

string result = first ?? second ?? third ?? "Unknown";
Console.WriteLine(result);  // Output: Rajesh
```

### Example 4: Practical Use
```csharp
class Person
{
    public string? name;
    public string? email;
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        
        string displayName = p.name ?? "No Name";
        string displayEmail = p.email ?? "No Email";
        
        Console.WriteLine($"Name: {displayName}");      // Output: Name: No Name
        Console.WriteLine($"Email: {displayEmail}");    // Output: Email: No Email
    }
}
```

---

## Common Interview Questions

**Q1. What's the difference between `==` and `Equals()`?**
- A: `==` compares references (for objects), `Equals()` compares values. For strings, both compare values.

**Q2. How do you find duplicate elements in an array?**
```csharp
int[] arr = { 1, 2, 2, 3, 3, 3, 4 };
Dictionary<int, int> count = new Dictionary<int, int>();

foreach (int num in arr)
{
    if (count.ContainsKey(num))
        count[num]++;
    else
        count[num] = 1;
}

foreach (var item in count)
{
    if (item.Value > 1)
        Console.WriteLine($"{item.Key} appears {item.Value} times");
}
```

**Q3. How do you reverse an array?**
```csharp
int[] arr = { 1, 2, 3, 4, 5 };
Array.Reverse(arr);
foreach (int num in arr)
    Console.Write(num + " ");  // Output: 5 4 3 2 1
```

**Q4. How do you sort an array?**
```csharp
int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };
Array.Sort(arr);
foreach (int num in arr)
    Console.Write(num + " ");  // Output: 1 1 2 3 4 5 6 9
```

---

## Tips for Solving Practice Problems

### For Array Problems:
- Know `Array.Sort()`, `Array.Reverse()`, `Array.IndexOf()`
- Remember: Arrays are 0-indexed
- Use nested loops for 2D arrays

### For String Problems:
- Know string methods: `Contains()`, `Replace()`, `Substring()`, `Split()`
- Remember: Strings are immutable
- Use loops to manipulate characters

### For Class Problems:
- Create meaningful classes
- Use constructors to initialize
- Add validation in setters
- Use properties for safe access

### For Collection Problems:
- Use `List<T>` for dynamic arrays
- Use `Dictionary<K, V>` for key-value pairs
- Use `foreach` loop for iteration
- Use LINQ for advanced queries

---

## Example: Complete Problem Solution

**Problem:** Create a student management system where you can:
1. Add students with name, roll number, and GPA
2. Display all students
3. Find students with GPA >= 3.5
4. Calculate average GPA

**Solution:**

```csharp
class Student
{
    public int rollNumber;
    public string name;
    public double gpa;
    
    public Student(int roll, string name, double gpa)
    {
        this.rollNumber = roll;
        this.name = name;
        this.gpa = gpa;
    }
    
    public void Display()
    {
        Console.WriteLine($"Roll: {rollNumber}, Name: {name}, GPA: {gpa}");
    }
}

class StudentManagement
{
    private List<Student> students = new List<Student>();
    
    public void AddStudent(int roll, string name, double gpa)
    {
        students.Add(new Student(roll, name, gpa));
    }
    
    public void DisplayAll()
    {
        foreach (Student s in students)
            s.Display();
    }
    
    public void DisplayTopStudents()
    {
        foreach (Student s in students)
        {
            if (s.gpa >= 3.5)
                s.Display();
        }
    }
    
    public double AverageGPA()
    {
        double total = 0;
        foreach (Student s in students)
            total += s.gpa;
        return total / students.Count;
    }
}

class Program
{
    static void Main()
    {
        StudentManagement sm = new StudentManagement();
        
        sm.AddStudent(101, "Rajesh", 3.8);
        sm.AddStudent(102, "Priya", 3.2);
        sm.AddStudent(103, "Amit", 3.9);
        
        Console.WriteLine("=== All Students ===");
        sm.DisplayAll();
        
        Console.WriteLine("\n=== Top Students (GPA >= 3.5) ===");
        sm.DisplayTopStudents();
        
        Console.WriteLine($"\n=== Average GPA ===");
        Console.WriteLine(sm.AverageGPA());
    }
}
```

---

## Summary Points to Remember ✨

1. **Read problem carefully** - Understand completely before coding
2. **Plan solution** - Write logic on paper first
3. **Use appropriate data types** - Choose wisely (int, string, array, list, etc.)
4. **Add validation** - Check user input
5. **Test with examples** - Try different cases
6. **Use meaningful names** - Makes code readable
7. **Add comments** - Explain complex logic
8. **Handle edge cases** - Empty data, null values, etc.
9. **Null-Coalescing Operator** - Use `??` to provide default values
10. **Know collection methods** - List, Dictionary, Array operations
11. **Practice regularly** - More practice = better problem-solving
12. **Review solutions** - Learn from others' approaches

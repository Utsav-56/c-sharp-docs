# ARRAYS AND COLLECTIONS - EXAM NOTES 📚

## What is an Array?

An **array** is a **fixed-size collection** of elements of the **same data type** stored in **contiguous memory locations**.

### Simple Analogy:
An array is like a **row of boxes** where each box stores one value:
- All boxes are same size
- Boxes are numbered (index starts from 0)
- You can store/retrieve values quickly

---

## Types of Arrays

### Type 1: Single-Dimensional Arrays (1D Array)

A simple linear array with elements arranged in a line.

#### Declaration:
```csharp
dataType[] arrayName = new dataType[size];
```

#### Examples:
```csharp
int[] numbers = new int[5];        // Array of 5 integers, initially 0
string[] names = new string[3];    // Array of 3 strings, initially null
bool[] flags = new bool[4];        // Array of 4 booleans, initially false
```

#### Initialization:
```csharp
// Method 1: During declaration
int[] numbers = { 10, 20, 30, 40, 50 };

// Method 2: Using new keyword
int[] numbers = new int[] { 10, 20, 30, 40, 50 };

// Method 3: Step by step
int[] numbers = new int[5];
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;
```

#### Accessing Elements:
```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(numbers[0]);  // Output: 10 (first element)
Console.WriteLine(numbers[2]);  // Output: 30 (third element)
Console.WriteLine(numbers[4]);  // Output: 50 (last element)

// Modify element
numbers[1] = 25;
Console.WriteLine(numbers[1]);  // Output: 25
```

#### Looping Through Array:
```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

// Method 1: For loop
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Method 2: Foreach loop
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

---

### Type 2: Multi-Dimensional Arrays (2D and 3D)

Arrays with more than one dimension.

#### 2D Array (Matrix)

```csharp
// Declaration
int[,] matrix = new int[3, 3];  // 3x3 matrix

// Initialization
int[,] matrix = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Accessing elements
Console.WriteLine(matrix[0, 0]);  // Output: 1 (first row, first column)
Console.WriteLine(matrix[1, 2]);  // Output: 6 (second row, third column)
Console.WriteLine(matrix[2, 1]);  // Output: 8 (third row, second column)

// Looping through 2D array
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
```

**Output:**
```
1 2 3
4 5 6
7 8 9
```

#### 3D Array

```csharp
// Declaration
int[,,] cube = new int[2, 2, 2];

// Initialization and access
int[,,] cube = new int[,,]
{
    { { 1, 2 }, { 3, 4 } },
    { { 5, 6 }, { 7, 8 } }
};

Console.WriteLine(cube[0, 0, 0]);  // Output: 1
Console.WriteLine(cube[1, 1, 1]);  // Output: 8
```

---

### Type 3: Jagged Arrays

An array of arrays where each row can have **different lengths**.

```csharp
// Declaration
int[][] jagged = new int[3][];

// Initialization
jagged[0] = new int[2];
jagged[1] = new int[3];
jagged[2] = new int[1];

// Alternative declaration and initialization
int[][] jagged = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6 }
};

// Accessing elements
Console.WriteLine(jagged[0][0]);  // Output: 1
Console.WriteLine(jagged[1][2]);  // Output: 5
Console.WriteLine(jagged[2][0]);  // Output: 6

// Looping
for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}
```

**Output:**
```
1 2
3 4 5
6
```

---

## Array Properties and Methods

### Properties

#### Length
Returns the total number of elements.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine(numbers.Length);  // Output: 5
```

---

### Useful Methods

#### Array.Sort()
Sorts array in ascending order.

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
Array.Sort(numbers);

foreach (int num in numbers)
    Console.Write(num + " ");  // Output: 1 2 5 8 9
```

---

#### Array.Reverse()
Reverses the order of elements.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
Array.Reverse(numbers);

foreach (int num in numbers)
    Console.Write(num + " ");  // Output: 5 4 3 2 1
```

---

#### Array.IndexOf()
Finds the index of an element.

```csharp
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine(Array.IndexOf(numbers, 30));  // Output: 2
Console.WriteLine(Array.IndexOf(numbers, 60));  // Output: -1 (not found)
```

---

#### Array.Exists()
Checks if element exists (using predicate).

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

bool exists = Array.Exists(numbers, element => element > 3);
Console.WriteLine(exists);  // Output: true
```

---

#### Array.Find()
Finds first element matching condition.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

int found = Array.Find(numbers, element => element > 3);
Console.WriteLine(found);  // Output: 4
```

---

## Collections (Generic Collections)

Collections are **dynamic**, meaning their size can **grow and shrink**.

### List<T>

A generic list that can grow/shrink dynamically.

```csharp
using System.Collections.Generic;

// Declaration
List<int> numbers = new List<int>();

// Add elements
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Access elements
Console.WriteLine(numbers[0]);  // Output: 10

// Count
Console.WriteLine(numbers.Count);  // Output: 3

// Remove element
numbers.Remove(20);

// Loop
foreach (int num in numbers)
    Console.WriteLine(num);
```

---

### Dictionary<K, V>

Key-value pairs, like a phonebook.

```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();

// Add
ages["Rajesh"] = 22;
ages["Priya"] = 21;
ages["Amit"] = 23;

// Access
Console.WriteLine(ages["Rajesh"]);  // Output: 22

// Check if key exists
if (ages.ContainsKey("Rajesh"))
    Console.WriteLine("Found!");

// Loop
foreach (var item in ages)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
```

---

## Real-World Example: Student Marks Management

```csharp
class Program
{
    static void Main()
    {
        // Array of marks
        int[] marks = { 85, 92, 78, 88, 95 };
        
        // Find highest mark
        Array.Sort(marks);
        Console.WriteLine("Highest: " + marks[marks.Length - 1]);
        
        // Calculate average
        int sum = 0;
        foreach (int mark in marks)
            sum += mark;
        
        double average = sum / (double)marks.Length;
        Console.WriteLine("Average: " + average);
        
        // Find marks >= 85
        Array.Sort(marks);
        foreach (int mark in marks)
        {
            if (mark >= 85)
                Console.WriteLine("Grade A: " + mark);
        }
    }
}
```

---

## Important Exam Questions

**Q1. What is an array?**
- A: A fixed-size collection of elements of the same type.

**Q2. What are the types of arrays?**
- A: Single-Dimensional, Multi-Dimensional (2D, 3D), and Jagged.

**Q3. What is the first index of an array?**
- A: 0 (zero-indexed)

**Q4. How do you find array length?**
- A: Use `.Length` property

**Q5. What's the difference between array and List?**
- A: Array is fixed size, List is dynamic (can grow/shrink)

---

## Summary Points to Remember ✨

1. Array = fixed-size collection
2. Arrays are **zero-indexed** (start from 0)
3. **1D Array:** Linear collection
4. **2D Array:** Matrix (rows and columns)
5. **3D Array:** 3-dimensional matrix
6. **Jagged Array:** Array of arrays with different lengths
7. **List<T>:** Dynamic collection (preferred for varying sizes)
8. **Dictionary<K,V>:** Key-value pairs
9. Use `.Length` for arrays, `.Count` for lists
10. Use `foreach` loop for easy iteration
11. Use `Array.Sort()` for sorting
12. Use `Array.Reverse()` for reversing
13. Know `Array.IndexOf()` and `Array.Find()`

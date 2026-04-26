# STRINGS - EXAM NOTES 📚

## What is a String?

A **string** is a sequence of **characters** used to represent text. 

### Examples:
- `"Hello"`
- `"John Doe"`
- `"C# Programming"`
- `"12345"`

---

## String Declaration

```csharp
string name = "John";
string message = "Hello, World!";
string empty = "";  // Empty string
```

---

## Important Property of Strings

### Strings are Immutable

**Immutable** means **cannot be changed** after creation. When you modify a string, a new string is created, and the old one is discarded.

```csharp
string text = "Hello";
text = "World";  // A NEW string is created, old "Hello" is discarded

Console.WriteLine(text);  // Output: World
```

---

## String Properties and Methods

### 1. Length Property

Returns the **number of characters** in the string.

```csharp
string name = "Rajesh";
Console.WriteLine(name.Length);  // Output: 6

string message = "Hello, World!";
Console.WriteLine(message.Length);  // Output: 13
```

---

### 2. ToUpper() Method

Converts string to **UPPERCASE**.

```csharp
string text = "hello";
string upper = text.ToUpper();
Console.WriteLine(upper);  // Output: HELLO
```

---

### 3. ToLower() Method

Converts string to **lowercase**.

```csharp
string text = "HELLO";
string lower = text.ToLower();
Console.WriteLine(lower);  // Output: hello
```

---

### 4. Contains() Method

Checks if string **contains** a specific substring. Returns `true` or `false`.

```csharp
string text = "Hello, World!";

Console.WriteLine(text.Contains("Hello"));    // Output: true
Console.WriteLine(text.Contains("World"));    // Output: true
Console.WriteLine(text.Contains("xyz"));      // Output: false
```

---

### 5. Replace() Method

**Replaces** all occurrences of a substring with another substring.

```csharp
string text = "Hello World";
string replaced = text.Replace("World", "C#");
Console.WriteLine(replaced);  // Output: Hello C#

string sentence = "I like cats. Cats are cute. Cats are friendly.";
string newSentence = sentence.Replace("Cats", "Dogs");
Console.WriteLine(newSentence);  // Output: I like cats. Dogs are cute. Dogs are friendly.
```

---

### 6. Substring() Method

Extracts a **part of the string** starting from a specific index.

```csharp
string text = "Hello, World!";

// Syntax: Substring(startIndex)
Console.WriteLine(text.Substring(0));      // Output: Hello, World!
Console.WriteLine(text.Substring(7));      // Output: World!

// Syntax: Substring(startIndex, length)
Console.WriteLine(text.Substring(0, 5));   // Output: Hello
Console.WriteLine(text.Substring(7, 5));   // Output: World
```

---

### 7. Split() Method

**Splits** string into an array of substrings based on a separator.

```csharp
string text = "apple,banana,cherry,date";
string[] fruits = text.Split(',');

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

**Output:**
```
apple
banana
cherry
date
```

---

### 8. Trim() Method

Removes **leading and trailing whitespace**.

```csharp
string text = "  Hello, World!  ";
string trimmed = text.Trim();
Console.WriteLine($"|{trimmed}|");  // Output: |Hello, World!|

Console.WriteLine($"|{text}|");     // Output: |  Hello, World!  |
```

---

### 9. TrimStart() Method

Removes **leading whitespace** only.

```csharp
string text = "  Hello  ";
string trimStart = text.TrimStart();
Console.WriteLine($"|{trimStart}|");  // Output: |Hello  |
```

---

### 10. TrimEnd() Method

Removes **trailing whitespace** only.

```csharp
string text = "  Hello  ";
string trimEnd = text.TrimEnd();
Console.WriteLine($"|{trimEnd}|");  // Output: |  Hello|
```

---

### 11. IndexOf() Method

Returns the **index** (position) of the **first occurrence** of a substring. Returns -1 if not found.

```csharp
string text = "Hello, World!";

Console.WriteLine(text.IndexOf("H"));       // Output: 0
Console.WriteLine(text.IndexOf("o"));       // Output: 4 (first occurrence)
Console.WriteLine(text.IndexOf("World"));   // Output: 7
Console.WriteLine(text.IndexOf("xyz"));     // Output: -1 (not found)
```

---

### 12. LastIndexOf() Method

Returns the **index** of the **last occurrence** of a substring.

```csharp
string text = "Hello, World! Hello!";

Console.WriteLine(text.LastIndexOf("H"));       // Output: 14 (last H)
Console.WriteLine(text.LastIndexOf("Hello"));   // Output: 14
```

---

### 13. StartsWith() Method

Checks if string **starts with** a specific substring.

```csharp
string text = "Hello, World!";

Console.WriteLine(text.StartsWith("Hello"));  // Output: true
Console.WriteLine(text.StartsWith("World"));  // Output: false
```

---

### 14. EndsWith() Method

Checks if string **ends with** a specific substring.

```csharp
string text = "Hello, World!";

Console.WriteLine(text.EndsWith("!"));       // Output: true
Console.WriteLine(text.EndsWith("World!"));  // Output: true
Console.WriteLine(text.EndsWith("Hello"));   // Output: false
```

---

### 15. Insert() Method

**Inserts** a substring at a specific position.

```csharp
string text = "Hello World";
string inserted = text.Insert(5, " Beautiful");
Console.WriteLine(inserted);  // Output: Hello Beautiful World
```

---

### 16. Remove() Method

**Removes** characters starting from a specific position.

```csharp
string text = "Hello, World!";

Console.WriteLine(text.Remove(5));      // Output: Hello
Console.WriteLine(text.Remove(5, 2));   // Output: HelloWorld
```

---

### 17. Compare() Method

**Compares** two strings. Returns 0 if equal, negative if first < second, positive if first > second.

```csharp
Console.WriteLine(string.Compare("Apple", "Apple"));    // Output: 0 (equal)
Console.WriteLine(string.Compare("Apple", "Banana"));   // Output: -1 (Apple < Banana)
Console.WriteLine(string.Compare("Banana", "Apple"));   // Output: 1 (Banana > Apple)
```

---

## String Concatenation

### Method 1: Using + Operator
```csharp
string first = "John";
string last = "Doe";
string full = first + " " + last;
Console.WriteLine(full);  // Output: John Doe
```

### Method 2: Using String Interpolation (Modern)
```csharp
string first = "John";
string last = "Doe";
int age = 25;
Console.WriteLine($"{first} {last} is {age} years old");  // Output: John Doe is 25 years old
```

### Method 3: Using String.Concat()
```csharp
string result = string.Concat("Hello", " ", "World");
Console.WriteLine(result);  // Output: Hello World
```

### Method 4: Using String.Format()
```csharp
string name = "Rajesh";
int age = 22;
string message = string.Format("Name: {0}, Age: {1}", name, age);
Console.WriteLine(message);  // Output: Name: Rajesh, Age: 22
```

---

## String vs StringBuilder

### String (Immutable)
```csharp
string text = "Hello";
text = text + " World";  // Creates a NEW string, old "Hello" is discarded
text = text + "!";       // Creates another NEW string
```

**Problem:** Creating many strings wastes memory!

### StringBuilder (Mutable)
```csharp
using System.Text;

StringBuilder text = new StringBuilder();
text.Append("Hello");
text.Append(" ");
text.Append("World");
text.Append("!");

Console.WriteLine(text);  // Output: Hello World!
```

**Benefit:** More efficient when making many modifications.

---

## Escaping Special Characters

Sometimes you need to include special characters in strings:

| Escape Sequence | Meaning | Example |
|---|---|---|
| `\"` | Double quote | `"He said \"Hello\""` |
| `\\` | Backslash | `"C:\\Users\\John"` |
| `\n` | Newline | `"Line1\nLine2"` |
| `\t` | Tab | `"Column1\tColumn2"` |
| `\r` | Carriage return | - |
| `\'` | Single quote | `'He\'s here'` |

```csharp
Console.WriteLine("She said \"Hello\"");  // Output: She said "Hello"
Console.WriteLine("Path: C:\\Users\\John");  // Output: Path: C:\Users\John
Console.WriteLine("Line1\nLine2");         // Output: Line1
                                           //         Line2
Console.WriteLine("Name\t:\tJohn");        // Output: Name	:	John
```

---

## Verbatim Strings

Use `@` before string to ignore escape sequences:

```csharp
string path = @"C:\Users\John\Documents";
Console.WriteLine(path);  // Output: C:\Users\John\Documents

string text = @"This is
a multiline
string";
Console.WriteLine(text);  // Output: This is
                          //         a multiline
                          //         string
```

---

## Null and Empty Strings

```csharp
string empty = "";           // Empty string (length = 0)
string? nullable = null;     // Null reference

Console.WriteLine(empty.Length);     // Output: 0
Console.WriteLine(empty == "");      // Output: true

// Check if string is null or empty
if (string.IsNullOrEmpty(empty))
{
    Console.WriteLine("String is null or empty");
}
```

---

## Practical Example: Email Validation

```csharp
class Program
{
    static bool IsValidEmail(string email)
    {
        // Check if email contains @
        if (!email.Contains("@"))
            return false;
        
        // Check if email contains .
        if (!email.Contains("."))
            return false;
        
        // Check position of @ and .
        int atIndex = email.IndexOf("@");
        int dotIndex = email.LastIndexOf(".");
        
        if (dotIndex <= atIndex)
            return false;
        
        return true;
    }
    
    static void Main()
    {
        Console.WriteLine(IsValidEmail("john@gmail.com"));      // Output: true
        Console.WriteLine(IsValidEmail("john.gmail.com"));      // Output: false
        Console.WriteLine(IsValidEmail("john@gmailcom"));       // Output: false
    }
}
```

---

## Important Exam Questions

**Q1. What is a string?**
- A: A sequence of characters used to represent text.

**Q2. Are strings mutable or immutable?**
- A: Immutable. Cannot be changed after creation.

**Q3. What is string interpolation?**
- A: Using `$` to embed variables/expressions inside a string.

**Q4. What's the difference between Length and Count?**
- A: Length is a property for strings, Count is a method for collections.

**Q5. When should you use StringBuilder?**
- A: When making many modifications to a string for better performance.

**Q6. What does Contains() return?**
- A: true if substring exists, false if not.

**Q7. What is the difference between IndexOf and LastIndexOf?**
- A: IndexOf returns position of first occurrence, LastIndexOf returns last.

---

## Summary Points to Remember ✨

1. String = sequence of characters
2. Strings are **immutable** (cannot be changed)
3. **Length** property returns number of characters
4. **ToUpper()** and **ToLower()** change case
5. **Contains()** checks if substring exists
6. **Replace()** replaces all occurrences
7. **Substring()** extracts part of string
8. **Split()** breaks string into array
9. **Trim()** removes whitespace
10. **IndexOf()** finds position of substring
11. **StartsWith()** and **EndsWith()** check beginning/end
12. Use **$** for string interpolation (modern)
13. Use **+** for concatenation (older)
14. Use **StringBuilder** for many modifications
15. Escape special characters with backslash: `\"`, `\\`, `\n`, `\t`
16. Use **@** for verbatim strings (ignore escapes)
17. Check null/empty with **string.IsNullOrEmpty()**

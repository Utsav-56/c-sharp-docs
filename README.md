# C# Complete Learning Guide

A comprehensive guide to learn C# programming from basics to advanced concepts. This documentation covers all the important topics you need to know to write professional C# code.

---

## Table of Contents

- [C# Complete Learning Guide](#c-complete-learning-guide)
  - [Table of Contents](#table-of-contents)
  - [Basic Concepts](#basic-concepts)
    - [Arrays](#arrays)
      - [Types of Arrays](#types-of-arrays)
    - [Constructors](#constructors)
      - [Types of Constructors](#types-of-constructors)
    - [Generics](#generics)
    - [Indexers](#indexers)
    - [Namespaces](#namespaces)
    - [Sealed and Static](#sealed-and-static)
  - [Types](#types)
    - [Classes vs Structs](#classes-vs-structs)
    - [Enums](#enums)
  - [Encapsulation](#encapsulation)
    - [Access Modifiers](#access-modifiers)
    - [Properties](#properties)
  - [Inheritance](#inheritance)
    - [Types of Inheritance](#types-of-inheritance)
      - [Single Inheritance](#single-inheritance)
      - [Multi-Level Inheritance](#multi-level-inheritance)
      - [Hierarchical Inheritance](#hierarchical-inheritance)
  - [Polymorphism](#polymorphism)
    - [Method Overloading (Compile-Time)](#method-overloading-compile-time)
    - [Method Overriding (Runtime)](#method-overriding-runtime)
    - [Operator Overloading](#operator-overloading)
  - [Strings and Characters](#strings-and-characters)
    - [Strings](#strings)
      - [String Basics](#string-basics)
      - [Useful String Methods](#useful-string-methods)
    - [Characters](#characters)
      - [Character Basics](#character-basics)
      - [Useful Character Methods](#useful-character-methods)
  - [Advanced Topics](#advanced-topics)
    - [Quick Reference Table](#quick-reference-table)
    - [Common Mistakes to Avoid](#common-mistakes-to-avoid)
    - [Tips for Writing Good Code](#tips-for-writing-good-code)
  - [Next Steps](#next-steps)


---

## Basic Concepts

### Arrays

Arrays are containers that hold a fixed number of items of the same type. Think of it like a row of boxes where each box holds the same kind of thing.

#### Types of Arrays

| Type | What it is | Example |
|------|-----------|---------|
| **Single-Dimensional** | A simple list | `int[] numbers = {1, 2, 3, 4, 5}` |
| **Multi-Dimensional** | A table with rows and columns | `int[,] table = new int[2, 3]` |
| **Jagged** | An array of arrays with different sizes | `int[][] mixed = new int[3][]` |

<details>
<summary>See code for Arrays</summary>

![Arrays Code Example](images/arrays.png)

</details>

---

### Constructors

A constructor is a special method that runs automatically when you create an object. It's like the "setup" method that prepares your object for use.

#### Types of Constructors

| Type | Purpose | When it runs |
|------|---------|--------------|
| **Default** | Made automatically, sets basic values | When you don't write any constructor |
| **Instance** | Takes information to set up the object | Every time you create an object |
| **Static** | Sets up shared values for the class | Only once when the class is first used |
| **Overloaded** | Multiple constructors with different inputs | Depends on which one you call |

<details>
<summary>See code for Constructors</summary>

![Constructors Code Example](images/constructors.png)

</details>

---

### Generics

Generics let you write code that works with any type. Instead of writing the same method multiple times for different types (like for int, string, double), you write it once and it works for all types.

**Simple idea:** A "generic" is like a template that can fill in the type later.

<details>
<summary>See code for Generics</summary>

![Generics Code Example](images/generic.png)

</details>

---

### Indexers

Indexers let you access items in a class using square brackets `[]`, just like you do with arrays. It's a way to make your custom class work like an array.

<details>
<summary>See code for Indexers</summary>

![Indexers Code Example](images/indexers.png)

</details>

---

### Namespaces

A namespace is like a folder for your code. It helps organize your code and prevents problems when two things have the same name.

**Real-world example:** Imagine two companies both have an employee named "John Smith". Namespaces let you say "Company1.John Smith" and "Company2.John Smith" to tell them apart.

<details>
<summary>See code for Namespaces</summary>

![Namespaces Code Example](images/namespace.png)

</details>

---

### Sealed and Static

<details>
<summary>See code for Sealed & Static</summary>

![Sealed and Static Code Example](images/sealed-and-static.png)

</details>

---

## Types

### Classes vs Structs

| Feature | Class | Struct |
|---------|-------|--------|
| **Type** | Reference (stored on heap) | Value (stored on stack) |
| **Default Constructor** | Can have | Cannot have |
| **Inheritance** | Can inherit from others | Cannot inherit |
| **Best for** | Complex objects | Simple data holders |
| **Performance** | Slower | Faster |

<details>
<summary>See code for Classes</summary>

![Classes Code Example](images/types_classes.png)

</details>

<details>
<summary>See code for Structs</summary>

![Structs Code Example](images/types_structs.png)

</details>

---

### Enums

An enum is a list of named values. Think of it like a menu - instead of passing a number or string, you pass a meaningful name.

<details>
<summary>See code for Enums</summary>

![Enums Code Example](images/types_enum.png)

</details>

---

## Encapsulation

Encapsulation means hiding the inside details of your class and only showing what's necessary. It's like a remote control - you see buttons but not the electronics inside.

### Access Modifiers

| Modifier | Visible Where | Use Case |
|----------|---------------|----------|
| **public** | Everywhere | Things anyone should use |
| **private** | Only inside this class | Secret internal data |
| **protected** | This class and child classes | For inherited classes to use |
| **internal** | Same project only | Project-level sharing |
| **protected internal** | Same project + child classes | Advanced scenarios |
| **private protected** | This class + child classes in same project | Advanced scenarios |

<details>
<summary>See code for Access Modifiers</summary>

![Access Modifiers Code Example](images/encapsulation_access-modifiers.png)

</details>

---

### Properties

Properties look like fields but they actually run code. They let you control how values are read and written. Think of them as smart getters and setters.

<details>
<summary>See code for Properties</summary>

![Properties Code Example](images/encapsulation_properties.png)

</details>

---

## Inheritance

Inheritance means one class can get all the features from another class. It's like a child inheriting traits from their parents.

### Types of Inheritance

#### Single Inheritance

One class inherits from one parent class.

<details>
<summary>See code for Single Inheritance</summary>

![Single Inheritance Code Example](images/inheritance_single.png)

</details>

---

#### Multi-Level Inheritance

Like a family tree - GrandChild inherits from Child, Child inherits from Parent.

<details>
<summary>See code for Multi-Level Inheritance</summary>

![Multi-Level Inheritance Code Example](images/inheritance_multi-level.png)

</details>

---

#### Hierarchical Inheritance

Multiple child classes inherit from the same parent.

<details>
<summary>See code for Hierarchical Inheritance</summary>

![Hierarchical Inheritance Code Example](images/inheritance_hierarchial.png)

</details>

---

## Polymorphism

Polymorphism means "many forms". One action can produce different results depending on the object. It's like a remote control button that does different things for different devices.

### Method Overloading (Compile-Time)

Same method name, different parameters.

<details>
<summary>See code for Method Overloading</summary>

![Method Overloading Code Example](images/polymorphism_overloading.png)

</details>

---

### Method Overriding (Runtime)

Child class provides its own version of a parent's method.

**Important:** Parent method must have `virtual` keyword, child uses `override` keyword.

<details>
<summary>See code for Method Overriding</summary>

![Method Overriding Code Example](images/polymorphism_overriding.png)

</details>

---

### Operator Overloading

Change what operators like `+`, `-`, `*` do with your custom objects.

<details>
<summary>See code for Operator Overloading</summary>

![Operator Overloading Code Example](images/polymorphism_operator-overriding.png)

</details>

---

## Strings and Characters

### Strings

A string is text - a sequence of characters. Strings in C# are **immutable**, meaning you can't change them once created. When you modify a string, a new string is created.

#### String Basics

<details>
<summary>See code for Strings</summary>

![Strings Code Example](images/strings_strings.png)

</details>

---

#### Useful String Methods

| Method | What it does | Example |
|--------|-------------|---------|
| `Length` | Count characters | `"Hello".Length` → 5 |
| `ToUpper()` | Make uppercase | `"hello".ToUpper()` → "HELLO" |
| `ToLower()` | Make lowercase | `"HELLO".ToLower()` → "hello" |
| `Contains()` | Check if text exists | `"Hello".Contains("ell")` → true |
| `Replace()` | Swap one text for another | `"cat".Replace("c", "b")` → "bat" |
| `Substring()` | Get part of string | `"Hello".Substring(0, 3)` → "Hel" |
| `Split()` | Break into pieces | `"a,b,c".Split(',')` → ["a", "b", "c"] |
| `Trim()` | Remove spaces | `" hello ".Trim()` → "hello" |
| `IndexOf()` | Find position of text | `"Hello".IndexOf("ll")` → 2 |



---

### Characters

A character is a single letter, number, or symbol. Use `char` for single characters.

#### Character Basics

<details>
<summary>See code for Characters</summary>

![Characters Code Example](images/strings_characters.png)

</details>

---

#### Useful Character Methods

| Method | What it does | Example |
|--------|-------------|---------|
| `IsDigit()` | Is it a number? | `char.IsDigit('5')` → true |
| `IsLetter()` | Is it a letter? | `char.IsLetter('A')` → true |
| `IsWhiteSpace()` | Is it a space/tab? | `char.IsWhiteSpace(' ')` → true |
| `ToUpper()` | Make uppercase | `char.ToUpper('a')` → 'A' |
| `ToLower()` | Make lowercase | `char.ToLower('A')` → 'a' |
| `IsUpper()` | Is it uppercase? | `char.IsUpper('A')` → true |
| `IsLower()` | Is it lowercase? | `char.IsLower('a')` → true |



---

## Advanced Topics

### Quick Reference Table

| Topic | Key Point | Use When |
|-------|-----------|----------|
| **Arrays** | Fixed-size collections | You need to store multiple items |
| **Constructors** | Initialize objects | Creating new objects |
| **Generics** | Work with any type | You want reusable code |
| **Indexers** | Array-like access | You want `[]` in your class |
| **Namespaces** | Organize code | Avoiding naming conflicts |
| **Sealed** | Can't inherit | You want to prevent extension |
| **Static** | No objects needed | For helper functions |
| **Classes** | Complex objects | Most of the time |
| **Structs** | Simple data | Small, performance-critical data |
| **Enums** | Named constants | Limited set of options |
| **Properties** | Smart getters/setters | Need validation or logic |
| **Inheritance** | Reuse code | Code shares common features |
| **Overloading** | Same name, different parameters | Multiple versions needed |
| **Overriding** | Child changes parent's method | Customize inherited behavior |

---

### Common Mistakes to Avoid

1. **Forgetting `virtual` keyword** - Parent method must be `virtual` to override it
2. **Modifying strings** - Strings are immutable, operations create new strings
3. **Creating objects from static classes** - Can't do `new StaticClass()`
4. **Inheriting from sealed classes** - Sealed means no inheritance allowed
5. **Not validating in properties** - Use setters to check values

---

### Tips for Writing Good Code

✅ **DO:**
- Use meaningful names for classes and methods
- Use properties instead of public fields
- Keep classes small and focused
- Use access modifiers to hide internal details
- Write comments explaining why, not what

❌ **DON'T:**
- Make everything public
- Create giant classes that do everything
- Use vague names like `data`, `temp`, `thing`
- Ignore validation in properties
- Skip using proper inheritance structure

---

## Next Steps

Now that you understand these concepts, try:
1. Creating your own classes with constructors
2. Building a class hierarchy with inheritance
3. Using properties with validation
4. Creating generic methods that work with different types
5. Combining multiple concepts in a project

---

**Happy Coding! 🎯**

For more detailed examples, check the individual `.cs` files in this repository.

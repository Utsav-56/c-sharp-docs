/*
What are Collections in C#?
    - Collections are classes used to store and manage groups of data dynamically.

Unlike arrays collections can grow and shrink in size as needed,:
    - No fixed size
    - More powerful operations (search, sort, etc.)


Two Main Types of Collections
1. Non-Generic Collections (old)
    - Store data as object
    - Need casting
    - Slower (boxing/unboxing)
    
    - Examples:
        - ArrayList
        - Hashtable
        - Stack
        - Queue
2. Generic Collections (modern & recommended)
    - Type-safe (List<int>, etc.)
    - No casting
    - Faster

    - Examples:
        - List<T>
        - Dictionary<TKey, TValue>
        - Stack<T>
        - Queue<T>



Important Collection Types (with examples)

1. List<T> (Generic, Most Used)
What it is:
    - Dynamic array (type-safe)
    - Stores same type only


METHODS in List<T> and ArrayList (similar methods):

| Method       | Use                |
| ------------ | ------------------ |
| `Add()`      | Add element        |
| `Remove()`   | Remove by value    |
| `RemoveAt()` | Remove by index    |
| `Insert()`   | Insert at index    |
| `Contains()` | Check existence    |
| `Count`      | Number of elements |









*/
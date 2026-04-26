/*
DICTIONARY in c#
A dictionary is a collection of key-value pairs, where each key is unique and maps to a specific value. 
It is part of the System.Collections.Generic namespace and is a generic collection


| Method                 | Use         |
| ---------------------- | ----------- |
| `Add(key, value)`      | Add pair    |
| `Remove(key)`          | Remove      |
| `ContainsKey(key)`     | Check key   |
| `ContainsValue(value)` | Check value |
| `Count`                | Size        |
| `Clear()`              | Remove all  |

*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> marks = new Dictionary<string, int>();

        marks.Add("Utsav", 90);
        marks.Add("Ram", 80);

        Console.WriteLine(marks["Utsav"]);

        if (marks.ContainsKey("Ram"))
        {
            Console.WriteLine("Ram exists");
        }

        foreach (var pair in marks)
        {
            Console.WriteLine(pair.Key + " = " + pair.Value);
        }
    }
}
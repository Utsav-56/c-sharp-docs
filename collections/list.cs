/*
List in c#
A List is a collection class that is dynamically resizable, meaning it can grow and shrink as needed.
It is part of the System.Collections.Generic namespace and is a generic collection, which means it can store elements of a specific type.


| Method         | Use             |
| -------------- | --------------- |
| `Add(x)`       | Add element     |
| `Remove(x)`    | Remove by value |
| `RemoveAt(i)`  | Remove by index |
| `Insert(i, x)` | Insert at index |
| `Contains(x)`  | Check existence |
| `Count`        | Number of items |
| `Clear()`      | Remove all      |


*/

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        numbers.Add(1); // List: [1]
        numbers.Add(2); // List: [1, 2]
        numbers.Add(3); // List: [1, 2, 3]  

        Console.WriteLine("contains 2: " + numbers.Contains(2)); // Output: True
        Console.WriteLine("count: " + numbers.Count); // Output: 3

        numbers.Remove(2); // List: [1, 3]
        Console.WriteLine("contains 2 after removal: " + numbers.Contains(2));
        Console.WriteLine("count after removal: " + numbers.Count); // Output: 2

        numbers.Insert(1, 4); // List: [1, 4, 3]
        Console.WriteLine("after insertion: " + string.Join(", ", numbers)); // Output

        numbers.Clear(); // List is now empty
        Console.WriteLine("count after clear: " + numbers.Count); // Output: 0
    }
}


/*
ARRAYLiST in c#
ArrayList is a non-generic collection class that can store elements of any type as objects.


It has same methods as lIst

*/
class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1); // ArrayList: [1]
        arrayList.Add("Hello"); // ArrayList: [1, "Hello"]
        arrayList.Add(3.14); // ArrayList: [1, "Hello", 3.14]

        Console.WriteLine("contains 'Hello': " + arrayList.Contains("Hello")); // Output: True
        Console.WriteLine("count: " + arrayList.Count); // Output: 3

        arrayList.Remove("Hello"); // ArrayList: [1, 3.14]
        Console.WriteLine("contains 'Hello' after removal: " + arrayList.Contains("Hello"));
        Console.WriteLine("count after removal: " + arrayList.Count); // Output: 2

        arrayList.Insert(1, "World"); // ArrayList: [1, "World", 3.14]
        Console.WriteLine("after insertion: " + string.Join(", ", arrayList)); // Output

        arrayList.Clear(); // ArrayList is now empty
        Console.WriteLine("count after clear: " + arrayList.Count); // Output:
    }
}
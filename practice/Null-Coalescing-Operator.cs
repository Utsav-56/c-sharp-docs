/*
The ?? operator provides a default value if a variable is null.

EXAMPLE:
    int? num = null;
    int result = num ?? 100;
    Console.WriteLine(result);  // Output: 100



String Interpolation in C#
    - String interpolation is a  way to insert variables directly inside a string using $.


Conclusion
    - Nullable types (?) allow value types to store null
    - ?? operator provides default value when null
    - String interpolation ($) makes string formatting easy and readable


*/

using System;

class Program
{
    static void Main()
    {
        int? num = null;

        // Null-coalescing operator
        int value = num ?? 50;

        string name = "Ram";

        // String interpolation
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Value: {value}");
    }
}
/*
STRINGS IN C#
    - A string in C# is a sequence of characters that is used to represent text.
    - Strings in C# are immutable, which means that once a string is created, it cannot be changed. 
    -  When you modify a string, a new string is created in memory with the modified value

STRING LITERALS IN C#
    - A string literal is a sequence of characters enclosed in double quotes (" ").
    - For example, "Hello, World!" is a string literal.


STRING INTERPOLATION IN C#
    - String interpolation is a feature in C# that allows you to embed expressions inside string literals. 
    - It is denoted by the $ symbol before the opening double quote of the string literal.
    - For example, $"Hello, {name}!" is a string interpolation that will replace {name} with the value of the variable name.

STRING METHODS IN C#
    - The string class in C# has several methods that can be used to manipulate strings.

1. string.Length: This property returns the length of the string.
2. string.ToUpper(): This method converts the string to uppercase.
3. string.ToLower(): This method converts the string to lowercase.
4. string.Contains(string value): This method checks if the string contains a specified substring.
5. string.Replace(string oldValue, string newValue): This method replaces all occurrences of a SUBSTRING
6. string.Substring(int startIndex, int length): This method returns a substring of the string starting from the specified index and with the specified length.
7. string.Split(char separator): This method splits the string into an array of substrings based on the specified separator character.
8. string.Trim(): This method removes all leading and trailing whitespace characters from the string.
9. string.IndexOf(string value): This method returns the index of the first occurrence of the specified substring in the string.
10. string.LastIndexOf(string value): This method returns the index of the last occurrence of the specified substring in the string.
...etc

*/

class Program
{
    static void Main(string[] args)
    {
        string name = "John Doe";
        int age = 30;

        // String interpolation
        string message = $"My name is {name} and I am {age} years old.";
        Console.WriteLine(message); // Output: My name is John Doe and I am 30 years old.

        // Using string methods
        Console.WriteLine(name.Length); // Output: 8
        Console.WriteLine(name.ToUpper()); // Output: JOHN DOE
        Console.WriteLine(name.ToLower()); // Output: john doe
        Console.WriteLine(name.Contains("Doe")); // Output: True
        Console.WriteLine(name.Replace("John", "Jane")); // Output: Jane Doe
        Console.WriteLine(name.Substring(0, 4)); // Output: John
        Console.WriteLine(name.Split(' ')[0]); // Output: John
        Console.WriteLine(name.Trim()); // Output: John Doe (no change since there are no leading or trailing whitespace)
        Console.WriteLine(name.IndexOf("Doe")); // Output: 5
        Console.WriteLine(name.LastIndexOf("o")); // Output: 6
    }
}
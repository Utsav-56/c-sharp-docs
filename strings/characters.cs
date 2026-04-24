/*
CHARACTERS IN C#
    A character in C# is a single Unicode character that is represented by the char data type.

CHARACTER LITERALS IN C#
    A character literal is a single character enclosed in single quotes (' ').
    For example, 'A', '1', and '$' are all character literals.

ESCAPE SEQUENCES IN C#
    Escape sequences are special characters that are used to represent certain characters 
    that cannot be represented directly in a character literal. 
    They are represented by a backslash (\) followed by a character.
    For example, '\n' represents a newline character, '\t' represents a tab character

CHARACTER METHODS IN C#
    The char data type has several methods that can be used to manipulate characters.
1. char.IsDigit(char c): This method checks if the character is a digit (0-9).
2. char.IsLetter(char c): This method checks if the character is a letter (a-z or A-Z).
3. char.IsWhiteSpace(char c): This method checks if the character is a whitespace character (space, tab, etc.).
4. char.ToUpper(char c): This method converts the character to uppercase.
5. char.ToLower(char c): This method converts the character to lowercase.
6. char.IsUpper(char c): This method checks if the character is an uppercase letter.
7. char.IsLower(char c): This method checks if the character is a lowercase letter.
8. char.IsLetterOrDigit(char c): This method checks if the character is a letter or a digit.
...etc




*/

class Program
{
    static void Main(string[] args)
    {
        char character1 = 'A';
        char character2 = '1';
        char character3 = '$';

        Console.WriteLine(char.IsDigit(character1)); // Output: False
        Console.WriteLine(char.IsLetter(character1)); // Output: True
        Console.WriteLine(char.IsWhiteSpace(character1)); // Output: False

        Console.WriteLine(char.ToUpper(character2)); // Output: '1' (digits are not affected by ToUpper)
        Console.WriteLine(char.ToLower(character1)); // Output: 'a'

        Console.WriteLine(char.IsUpper(character1)); // Output: True
        Console.WriteLine(char.IsLower(character1)); // Output: False
        Console.WriteLine(char.IsLetterOrDigit(character3)); // Output: False
    }
}
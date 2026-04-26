/*
Operator Overloading in C#
    - Operator overloading allows you to redefine how operators (like +, -, <, ==) work for user-defined types (classes/structs).


Important:
    - Must be public
    - Must be static
    - At least one operand must be of the class

Why Operator Overloading Must Be Static in C#?

    - The operater overloadibng is methods on more then 1 of the operands.
    - so it is associated to the class rather than to the instance of the class.

    - if it was not static then it will be associated  with just the instance of the class

What happens if you try to make them instance methods?
    If you try:
        - You’ll get a compile-time error because:
        - C# does not allow operator overloading methods to be non-static
    

*/

class Square
{
    public int length;

    public Square(int length)
    {
        this.length = length;
    }

    // Overloading the + operator to add two Square objects together
    // this will add with our own logic
    public static int operator +(Square s1, Square s2)
    {
        return s1.length + s2.length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5);
        Square square2 = new Square(10);

        // Using the overloaded + operator to add two Square objects together
        int result = square1 + square2;

        Console.WriteLine("Result: " + result); // Output: Result: 15
    }
}



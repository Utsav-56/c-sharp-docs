/*
What is polymorphism in C#?
Polymorphism is a fundamental object-oriented programming (OOP) concept
that allows single action to give different results.

Types of polymorphism in C#:
1. Compile-time Polymorphism (Method Overloading and Operator Overloading)
2. Runtime Polymorphism (Method Overriding)
*/

// Example of compile-time polymorphism (method overloading)
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(1, 2)); // Output: 3
        Console.WriteLine(calc.Add(1.5, 2.5)); // Output: 4.0
        Console.WriteLine(calc.Add(1, 2, 3)); // Output: 6
    }
}
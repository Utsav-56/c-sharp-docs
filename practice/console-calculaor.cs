/*
Wap to make a console calculator for add,  sub,  div only using multiple inheritance
*/

using System;

// Interface for Addition
interface IAddition
{
    double Add(double a, double b);
}

// Interface for Subtraction
interface ISubtraction
{
    double Subtract(double a, double b);
}

// Interface for Division
interface IDivision
{
    double Divide(double a, double b);
}

// Calculator class implementing multiple interfaces
class Calculator : IAddition, ISubtraction, IDivision
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }

        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        double a = 10;
        double b = 5;

        Console.WriteLine("Addition: " + calc.Add(a, b));
        Console.WriteLine("Subtraction: " + calc.Subtract(a, b));
        Console.WriteLine("Division: " + calc.Divide(a, b));
    }
}
/*
INTERFACES IN C#
    An interface is a contract that defines a set of methods and properties that a class must implement

An interface can only contain method declarations (no implementation) and properties (without backing fields).

iNTERFACES IN C# SUPPORT MULTIPLE INHERITANCE
    A class can implement multiple interfaces, which allows for more flexible and modular code design.

Example:
*/
using System;
interface IShape
{
    // The class implementing this interface must provide an implementation for this method
    double Area();
}

class Rectangle : IShape
{
    public double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        IShape s = new Rectangle(5, 4);
        Console.WriteLine("Area: " + s.Area());
    }
}



/*
How does interface support multiple inheritance in C#?
    A class can implement multiple interfaces by separating them with commas in the class declaration. 
    This allows a class to inherit the behavior defined in multiple interfaces.

Example of multiple inheritance using interfaces in C#:
*/
interface IShape
{
    double Area();
}

interface IColor
{
    string Color { get; set; }
}

class Rectangle : IShape, IColor
{
    public double length, width;
    public string Color { get; set; }

    public Rectangle(double l, double w, string color)
    {
        length = l;
        width = w;
        Color = color;
    }

    public double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 4, "Red");
        Console.WriteLine("Area: " + rect.Area());
        Console.WriteLine("Color: " + rect.Color);
    }
}
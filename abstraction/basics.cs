/*
Data Abstraction in C#
    Data Abstraction is the process of hiding implementation details and showing only the essential features of an object.

In simple terms:
    Show what an object does, not how it does it.


Ways to Achieve Data Abstraction in C#
    1. Abstract Classes
        - Declared using abstract keyword
        - Can have:
            - Abstract methods (no body)
            - Normal methods (with body)


    2. Interfaces
        - Declared using interface
        - Contains only method declarations (no implementation)
        - Supports multiple inheritance

Example:
Here:
    - User only calls Area()
    - Internal calculation is hidden → abstraction

*/
abstract class Shape
{
    public abstract double Area(); // abstract method (no body)

}

class Rectangle : Shape
{
    public double length, width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Rectangle(5, 4);
        Console.WriteLine("Area: " + s.Area());
    }
}
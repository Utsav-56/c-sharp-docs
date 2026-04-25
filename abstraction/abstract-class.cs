/*
Abstract class in C#
    An abstract class is a class that cannot be instantiated and
    It can contain both abstract methods (without implementation) and concrete methods (with implementation).

Abstract class can have everything that a normal class can have, 
But we can never use the abstract class directly or create an object of it,

we can only inherit from it and use its members in the derived class.

*/

//EXAMPLE OF ABSTRACT CLASS IN C# 

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
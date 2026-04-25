/*
Why Operator Overloading Must Be Static in C#?

The operater overloadibng is methods on more then 1 of the operands.
so it is associated to the class rather than to the instance of the class.

if it was not static then it will be associated  with just the instance of the class
and it will not be able to access the other operand which is not the instance of the class.

What happens if you try to make them instance methods?
    If you try:
        - You’ll get a compile-time error because:
        - C# does not allow operator overloading methods to be non-static
    
*/

using System;
using System.Security;
class Box
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Box(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public int Volume()
    {
        return Length * Width * Height;
    }

    public intt SurfaceArea()
    {
        return 2 * (Length * Width + Length * Height + Width * Height);
    }


    public static Box operator <(Box b1, Box b2)
    {
        return b1.Volume() < b2.Volume();
    }

    public static Box operator ==(Box b1, Box b2)
    {
        return b1.Length == b2.Length && b1.Width == b2.Width && b1.Height == b2.Height;
    }

    public static Box operator &(Box b1, Box b2)
    {
        return b1.SurfaceArea() & b2.SurfaceArea();
    }


}


class Program
{
    static void Main(string[] args)
    {
        Box box1 = new Box(2, 3, 4);
        Box box2 = new Box(5, 6, 7);

        Console.WriteLine("Box 1 Volume: " + box1.Volume());
        Console.WriteLine("Box 2 Volume: " + box2.Volume());

        Console.WriteLine("Box 1 Surface Area: " + box1.SurfaceArea());
        Console.WriteLine("Box 2 Surface Area: " + box2.SurfaceArea());

        Console.WriteLine("Is Box 1 smaller than Box 2? " + (box1 < box2));
        Console.WriteLine("Are Box 1 and Box 2 equal? " + (box1 == box2));
        Console.WriteLine("Bitwise AND of Surface Areas: " + (box1 & box2));
    }
}

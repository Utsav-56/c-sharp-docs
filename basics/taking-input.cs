/*
In c# input is taken using Console.ReadLine() method, which reads input as string

Example:


*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); // Takes input as string
        Console.WriteLine("Hello, " + name);
    }
}
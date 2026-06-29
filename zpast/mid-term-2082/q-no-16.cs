using System;

delegate void MessageDelegate();

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome to C#");
    }

    static void Learn()
    {
        Console.WriteLine("Learning Delegates");
    }

    static void Goodbye()
    {
        Console.WriteLine("Thank You!");
    }

    static void Main()
    {
        MessageDelegate msg = Welcome;
        msg += Learn;
        msg += Goodbye;

        Console.WriteLine("Invoking Multicast Delegate:");
        // prints all the methods in order they were added to the delegate
        msg();
    }
}
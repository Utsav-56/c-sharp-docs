/*
WAP to Demonstrate 5 Services of Console Class
    1. ReadLine(): Reads a line of input from the console.
    2. WriteLine(): Writes a line of text to the console.
    3. Write(): Writes text to the console without a newline.
    4. ReadKey(): Reads a single key from the console.
    5. ReadLine(): Reads a line of input from the console.
    6. Clear(): Clears the console screen.
    7. Beep(): Plays a beep sound.
    

*/
// Example:
using System;

class Program
{
    static void Main()
    {
        // Write() → Prints without newline
        Console.Write("Enter your name: ");

        // ReadLine() → Takes input from user
        string name = Console.ReadLine();

        // WriteLine() → Prints with newline
        Console.WriteLine("Hello, " + name);

        // Beep() → Plays a beep sound
        Console.Beep();

        Console.WriteLine("Press any key to clear screen...");
        //  ReadKey() → Waits for a key press of single key
        Console.ReadKey();   // extra useful method

        // Clear() → Clears the console screen
        Console.Clear();

    }
}
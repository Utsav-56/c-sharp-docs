/*

Paramaters can be defined as the variables that are used to pass data into methods. 
They allow us to provide input to methods.


We can pass the paramaters in 2 basic ways:
1. By Value (default)
2. By Reference (using ref keyword)

In C#, there are 4 main types of parameters:

    1. Value Parameters (pass by value)
       - A COPY of the value is passed
       - Changes inside method DO NOT affect original variable

    2. Reference Parameters (ref keyword, pass by reference)
       - ORIGINAL variable is passed (no copy)
       - Changes inside method WILL affect original variable
       - Must be initialized before passing

    3. Output Parameters (out, an upgrade to ref)
       - Used to RETURN values from method
       - No need to initialize before passing
       - MUST assign value inside method

    4. Params Parameters (params, unknown number of arguments)
       - Allows passing VARIABLE number of arguments
       - Treated as an ARRAY inside the method
*/
class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before ::");
        Console.WriteLine($"a = {a}"); // Output: 5
        Console.WriteLine($"b = {b}"); // Output: 10


        ChangeByValue(a);
        ChangeByRef(ref b);

        Console.WriteLine("After ::");
        Console.WriteLine($"a = {a}"); // Output: 5 (unchanged)
        Console.WriteLine($"b = {b}"); // Output: 20 (changed by ref)
    }

    static void ChangeByValue(int x)
    {
        x = x + 10; // modifies only local copy
    }

    static void ChangeByRef(ref int x)
    {
        x = x + 10;
    }

}
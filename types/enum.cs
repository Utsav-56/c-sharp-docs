/*
What are enums in C#?
Enums (short for "enumerations") are a value type in C# that allows you to define a set of named constants. 
They are used to represent a group of related values.


Naming an enum:
1. Enums must be a string we cannot use numbers or special characters in the name of an enum.



Example of enums in C#
*/

class Program
{
    // Define an enum for days of the week
    enum DaysOfWeek
    {

        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }

    static void Main(string[] args)
    {
        // Using the enum
        DaysOfWeek today = DaysOfWeek.monday;
        Console.WriteLine("Today is: " + today); // Output: Today is: Monday


        /*
        We can also convert the enum to its `int` value and vice versa.
        For understanding think of it as arrays where the first element is at index 0, the second element is at index 1 and so on.
        */
        int dayValue = (int)DaysOfWeek.monday; // Convert enum to int
        Console.WriteLine("The integer value of Monday is: " + dayValue); // Output: The integer value of Monday is: 1

        DaysOfWeek dayFromValue = (DaysOfWeek)1; // Convert int to enum
        Console.WriteLine("The day corresponding to integer value 1 is: " + dayFromValue); // Output: The day corresponding to integer value 1 is: Monday
    }
}
/*
What are generics in C#?
Generics in C# allow you to put a placeholder for the type of data that you want to use in a class, method, or interface.

Benefits of using generics:
1. Type Safety: Generics provide type safety at compile time
2. Code Reusability: You can create a single class, method, or interface that can work with any data type.`

*/

/*
Lets say we have 3 different types of arrays, int, string and double.
And we want to create a method that can print the elements of any of these arrays.

Without generics, we would have to create three different methods to print the elements of each type of array.
But with generics, we can create a single method that can print the elements of any type of array.
*/

class WithoutGenerics
{
    public void PrintIntArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintStringArray(string[] arr)
    {
        foreach (string item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintDoubleArray(double[] arr)
    {
        foreach (double item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        string[] stringArray = { "Hello", "World" };
        double[] doubleArray = { 1.1, 2.2, 3.3 };

        PrintIntArray(intArray);
        PrintStringArray(stringArray);
        PrintDoubleArray(doubleArray);
    }
}

/*
Look yourself at the above code, we have three different methods to print the elements of each type of array.
This makes the code messy and hard to maintain.

But see the example below,
We can use generics to create a single method that can print the elements of any type of array.
*/
class WithGenerics
{
    public void PrintArray<T>(T[] arr)
    {
        foreach (T item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        string[] stringArray = { "Hello", "World" };
        double[] doubleArray = { 1.1, 2.2, 3.3 };

        PrintArray(intArray);
        PrintArray(stringArray);
        PrintArray(doubleArray);
    }
}
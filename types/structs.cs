/*
STRUCTS IN C#
    A struct is similar to a class in C#, but it is a value type rather than a reference type.

What do you mean by value type and reference type?
In C#, value types are stored on the stack and hold the actual data, 
while reference types are stored on the heap and hold a reference to the data.

Key differences between structs and classes in C#:
1. Structs are value types, while classes are reference types.
2. Structs cannot have a default constructor (a constructor without parameters), while classes can.
3. Structs cannot inherit from other classes or structs, while classes can.
4. Structs are typically used for small, simple data structures, while classes are used for more complex objects.

*/

// Example of a struct in C#
struct Animal
{
    public string name;
    public int age;


    /*
    Structs can have constructors, but they must take parameters and cannot be parameterless.
    */
    Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }


    public void sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }

    public void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the struct
        Animal animal1 = new Animal("Dog", 5);
        animal1.sound(); // Output: The animal makes a sound.
        animal1.display(); // Output: Name: Dog, Age: 5
    }
}

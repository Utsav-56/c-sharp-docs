/*
What are sealed  classes in C#?
A sealed class is a class that cannot be inherited. 
It can be used as a normal class and even be instantiated, 
But we cannot extend it and use it in inheritance.


NOT only the class can be sealed but also the methods can be sealed, 
when a method is sealed, it cannot be overridden in the derived class,
Not only that but also the properties and events can be sealed as well.


What are static classes in C#?
A static class is a class that cannot be instantiated and can only contain static members.
We cannot create an object of a static class, and all members of a static class must be static.




*/

//EXAMPLE OF SEALED CLASS IN C#
sealed class Animal
{
    public void sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }



}

// This will cause error because we cannot inherit from a sealed class
class Dog : Animal // ERROR 
{
    public void bark()
    {
        Console.WriteLine("The dog barks.");
    }

    sealed public void guard()
    {
        Console.WriteLine("The dog guards the house.");
    }
}

//EXAMPLE OF STATIC CLASS IN C#
static class Person
{
    // Even the members of a static class must be static
    public static int id;
    public static string name;

    public static void display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }

}

class Program
{
    static void Main(string[] args)
    {
        // We cannot create an object of a static class
        // Person person1 = new Person(); // ERROR

        // We must use the class name to access the members of a static class directly
        Person.id = 1;
        Person.name = "John";
        Person.display(); // Output: ID: 1, Name: John
    }
}
/*
What are classes in C#?
A class is a blueprint for creating objects in C#.
It defines the properties and behaviors of the objects that will be created from it.


What are objects in C#?
An object is an instance of a class in C#.
An object has state (properties) and behavior (methods) defined by its class.
in c# objects are created using the 'new' keyword followed by the class name and parentheses.


What are fields in C#?
Fields are variables that are members of a class in C#.

What are methods in C#?
Methods are functions that are members of a class in C#.
Methods define the behavior of the objects created from the class.

*/

// Example of a class in C#
class Student
{
    // Properties of the class
    public string name;
    public int age;

    // Method of the class
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
        // Creating an object of the Student class
        Student student1 = new Student();
        student1.name = "Alice";
        student1.age = 20;
        student1.display(); // Output: Name: Alice, Age: 20

        // Creating another object of the Student class
        Student student2 = new Student();
        student2.name = "Bob";
        student2.age = 22;
        student2.display(); // Output: Name: Bob, Age: 22
    }
}
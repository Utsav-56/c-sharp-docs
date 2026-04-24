/*
What is inheritance in C#?
Inheritance is a fundamental object-oriented programming (OOP) concept 
that allows a class to inherit properties and behaviors (fields and methods) from another class.

NOTE: In c# we dont have extends keyword like in java, 
instead we use a colon (:) to indicate that a class is inheriting from another class.

TYPES OF INHERITANCE IN C#:
1. Single Inheritance: A class inherits from a single parent class.
2. Multilevel Inheritance: A class inherits from a parent class, which in turn inherits from another parent class.
     - Suppose, Class C inherits from class B,  and class B inherits from class A.
     - Indirectly, class C inherits from class A as well.
     - this is called multilevel inheritance. 

3. Hierarchical Inheritance: Multiple classes inherit from a single parent class.
        - Suppose, Class DOG and class CAT both inherit from class ANIMAL.
        - This is called hierarchical inheritance.

4. Multiple Inheritance: A class can inherit from multiple parent classes. 
   - C# does not support multiple inheritance with classes to avoid ambiguity, but it can be achieved using interfaces.


NOTES: TO java programmers:
1. In C#, we use a colon (:) to indicate inheritance, while in Java we use the 'extends' keyword.
2. In java we had the 'super' keyword to refer to the parent class, but in C# we use the 'base' keyword for the same purpose.
    - for e.g, super.sound() in java would be base.sound() in C#.

3. In c# we must put the `virtual` keyword in the parent classs to make it overridable, and we must put the `override` keyword in the child class to override the method. 
   - In java we dont have to put any keyword to make a method overridable, and we can override it directly in the child class.

*/

/// Example of single inheritance in C#
class Animal
{
    public void sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.sound(); // Output: The animal makes a sound.
        dog1.bark(); // Output: The dog barks.

        /*
        Here the dog automativally gets the sound() method from the Animal class 
        because it inherits from it.
        */
    }
}
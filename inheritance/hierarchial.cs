/*
 HIERARCHICAL INHERITANCE
    In hierarchical inheritance, multiple classes inherit from a single parent class. 
    
    For example,
     Class DOG and class CAT both inherit from class ANIMAL.    
*/

/// Example of hierarchical inheritance in C#
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

class Cat : Animal
{
    public void meow()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.sound(); // Output: The animal makes a sound.
        dog1.bark(); // Output: The dog barks.

        Cat cat1 = new Cat();
        cat1.sound(); // Output: The animal makes a sound.
        cat1.meow(); // Output: The cat meows.

        /*
        Here both the dog1 and cat1 objects automatically get the sound() method from the Animal class 
        because they both inherit from it.
        */
    }
}
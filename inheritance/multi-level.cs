/*
MULTI-LEVEL INHERITANCE
   In multilevel inheritance, a class inherits from a parent class, 
   which in turn inherits from another parent class. 

   For example,
    Class GermanShepherd inherits from class Dog, and class Dog inherits from class Animal.
*/

/// Example of multilevel inheritance in C#
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

class GermanShepherd : Dog
{
    public void guard()
    {
        Console.WriteLine("The German Shepherd guards the house.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GermanShepherd germanShepherd1 = new GermanShepherd();
        germanShepherd1.sound(); // Output: The animal makes a sound.
        germanShepherd1.bark(); // Output: The dog barks.
        germanShepherd1.guard(); // Output: The German Shepherd guards the house.

        /*
        Here the germanShepherd1 object automatically gets the sound() method from the Animal class 
        and the bark() method from the Dog class because it inherits from both of them.
        */
    }
}
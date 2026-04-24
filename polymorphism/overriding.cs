/*
METHOD OVERRIDING
    It is a feature that allows a child class to rovide its own implementation
    of a method that is already defined in its parent class.

To override a method in C#, the method in the parent class must be marked with the 'virtual' keyword,

What is the 'virtual' keyword in C#?
    The 'virtual' keyword is used to indicate that a method can be overridden in a derived class. 
    Without the 'virtual' keyword, a method cannot be overridden, 
    and any attempt to do so will result in a compile-time error.

*/

class Animal
{
    public virtual void sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }

    public void eat()
    {
        Console.WriteLine("The animal eats food.");
    }
}

class Dog : Animal
{

    /*
    We can override the sound method because it is marked as virtual in the parent class,
    */
    public override void sound()
    {
        Console.WriteLine("The dog barks.");
    }

    // We cannot override the eat method because it is not marked as virtual in the parent class,
    // if we do something like, 
    // public override void eat() // ERROR
    // it will cause a compile-time error because the eat method is not virtual in the parent class.
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.sound(); // Output: The dog barks.
        dog1.eat(); // Output: The animal eats food.

    }
}
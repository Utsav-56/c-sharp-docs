using System;
/**
Vehicle is an abstract class here, because it  has abstract keyword
*/
abstract class Vehicle
{
    /**
       this is a abstract method,  
       All abstract methods must have the public abstract keybord in the starting else it is an error
    */
    public abstract void Start();

    /**
        This is a normal method, it can have body and can be called from the derived class
    */
    public void Stop()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}

/**
    This is a interface and look there is just the method signature,
    here we dont need the public access modifier, because all methods in interface are public and abstract by default
*/
interface IHorn
{
    /*
        Only the signature is here, 
    */
    void Horn();
}

class Car : Vehicle, IHorn
{
    /**
        This is the implementation of the Start method from the Vehicle abstract class
    */
    public override void Start()
    {
        Console.WriteLine("Car started.");
    }

    /**
        This is the implementation of the Horn method from the IHorn interface
    */
    public void Horn()
    {
        Console.WriteLine("Beep! Beep!");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        car.Start();
        car.Horn();
        car.Stop();
    }
}
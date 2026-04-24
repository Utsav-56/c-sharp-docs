/*
In c# we can also override operators to provide custom behaviour.

For example, we can override the + operator to add two objects of a class together.
*/

class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Overloading the + operator to add two Person objects together
    // this will add with our own logic
    public static Person operator +(Person p1, Person p2)
    {
        Person temp = new Person("", 0);
        temp.name = p1.name + " " + p2.name; // Concatenating
        temp.age = p1.age + p2.age; // Adding ages
        return temp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Alice", 30);
        Person person2 = new Person("Bob", 25);

        // Using the overloaded + operator to add two Person objects together
        Person person3 = person1 + person2;

        Console.WriteLine("Name: " + person3.name); // Output: Name: Alice Bob
        Console.WriteLine("Age: " + person3.age); // Output: Age: 55
    }
}
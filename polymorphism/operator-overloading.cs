/*
Operator Overloading in C#
    - Operator overloading allows you to redefine how operators (like +, -, <, ==) work for user-defined types (classes/structs).


Important:
    - Must be public
    - Must be static
    - At least one operand must be of the class

Why Operator Overloading Must Be Static in C#?

    - The operater overloadibng is methods on more then 1 of the operands.
    - so it is associated to the class rather than to the instance of the class.

    - if it was not static then it will be associated  with just the instance of the class

What happens if you try to make them instance methods?
    If you try:
        - You’ll get a compile-time error because:
        - C# does not allow operator overloading methods to be non-static
    

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
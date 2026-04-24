/*
PROPERTIES IN C#:
Properties looks like fields but they are actually special methods called accessors.
Properties are used to encapsulate the fields of a class and provide a way to access and modify them in a controlled manner.
Properties can have get and set accessors, which are used to read and write the value of the property respectively.

Why use properties instead of fields?
1. Encapsulation: Properties allow you to control the access to the fields.
2. Validation: You can add validation logic in the set accessor to ensure that the value being assigned to the property is valid.
    - for e.g, ensurre that age is not negative.

*/

class Person
{
    private string name;
    private int age;

    // Property for name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for age with validation
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                age = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Using properties to set values
        person.Name = "Alice";
        person.Age = 30;

        // Using properties to get values
        Console.WriteLine("Name: " + person.Name); // Output: Name: Alice
        Console.WriteLine("Age: " + person.Age); // Output: Age: 30

        // Trying to set a negative age to see the validation in action
        person.Age = -5; // Output: Age cannot be negative.
    }
}
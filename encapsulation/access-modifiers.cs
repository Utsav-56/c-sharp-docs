/*
ACCESS MODIFIERS IN C#:

Types of access modifiers in C#:
1. Public: The member is accessible from anywhere in the program.
2. Private: The member is only accessible within the class it is defined in.
3. Protected: The member is accessible within the class it is defined in and in derived classes.
4. Internal: The member is accessible within the same assembly, but not from another assembly.
5. Protected Internal: The member is accessible within the same assembly and from derived classes in other assemblies.
6. Private Protected: The member is accessible within the same class and from derived classes in the same assembly.
*/

class Person
{
    public string name; // Public member
    private int age; // Private member
    protected string address; // Protected member
    internal string phoneNumber; // Internal member
    protected internal string email; // Protected Internal member
    private protected string ssn; // Private Protected member

    public void SetAge(int age)
    {
        this.age = age; // Accessing private member within the class
    }

    public int GetAge()
    {
        return age; // Accessing private member within the class
    }
}

class Employee : Person
{
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name); // Accessing public member
        // Console.WriteLine("Age: " + age); // ERROR: Cannot access private member
        Console.WriteLine("Address: " + address); // Accessing protected member
        Console.WriteLine("Phone Number: " + phoneNumber); // Accessing internal member
        Console.WriteLine("Email: " + email); // Accessing protected internal member
        // Console.WriteLine("SSN: " + ssn); // ERROR: Cannot access private protected member
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Alice"; // Accessing public member
        // person.age = 30; // ERROR: Cannot access private member
        person.phoneNumber = "123-456-7890"; // Accessing internal member
        person.email = "alice@example.com"; // Accessing protected internal member  
    }
}
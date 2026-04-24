/*
What are constructors in C#?
A constructor is a special method in C# that is automatically called when an instance of a class is created.
it is used to initialize the object and set its initial state.

Types of constructors in C#:
1. Default Constructor: 
A constructor that is automatically created by the compiler if no constructor is defined in the class.
it does not take any parameters and initializes the object with default values.


2. Instance Constructor: 
A constructor that is called when an instance of a class is created.
it takes parameters and initializes the object with the provided values.

3. Static Constructor:
A constructor that is called only once, when the class is first accessed.
it is used to initialize static members of the class.
No matter how many instances of the class are created, the static constructor will only be called once.

4. Overloaded Constructor:
When more then one constructor is defined in a class, it is called constructor overloading.
The constructors must have different parameter signatures to be considered overloaded.


Opposite to constructors we have destructors, which are used to clean up resources when an object is destroyed.
Destructors are defined using the ~ symbol and do not take any parameters.

*/
class Student
{
    public string name;
    public int age;

    // Default constructor
    public Student()
    {
        Console.WriteLine("Default constructor called");
        name = "Unknown";
        age = 0;
    }

    // Instance constructor
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Instance constructor called");
    }

    // Overloaded constructor
    public Student(string name)
    {
        this.name = name;
        age = 0;
        Console.WriteLine("Overloaded constructor with only name parameter called");
    }

    // Static constructor
    static Student()
    {
        Console.WriteLine("Static constructor called");
    }

    public void display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Student using the default constructor
        // this is 1st time we are accessing the Student class, so the static constructor will also be called
        Student student1 = new Student();
        student1.display();

        // Creating an instance of Student using the instance constructor
        // this is 2nd time we are accessing the Student class, so the static constructor will not be called
        Student student2 = new Student("Alice", 20);
        student2.display();

        // Creating an instance of Student using the overloaded constructor
        Student student3 = new Student("Bob");
        student3.display();
    }
}


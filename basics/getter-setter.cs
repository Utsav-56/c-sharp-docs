/*
In c# properties are a way to provide controlled access to the fields of a class.
they allow us to define getter and setter methods for a field, 
which helps to do somee processing before accessing or modifying the field value.

for e.g, 
nsure age is neveer negative, we can use a property to validate the input before setting the age field.
*/

class Person
{
    private int _age;

    public int age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                _age = value;
            }
        }
    }
}
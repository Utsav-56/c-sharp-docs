/*
Question::

WAP to create a class StudentCollection that stores student names. 
Overload the indexer to get or set student names by index. 
Demonstrate adding and displaying student names using the indexer in Main().

Solution::
here we create a class StudentCollection that has an array of strings to store student names.
We overload the indexer to allow getting and setting student names by index.

*/

using System;
class StudentCollection
{
    private string[] students;

    public StudentCollection(int size)
    {
        students = new string[size];
        count = 0;
    }

    // Indexer to get or set student names by index
    public string this[int index]
    {
        get
        {
            return students[index];
        }
        set
        {
            students[index] = value;
        }
    }

    public void Display()
    {
        Console.WriteLine("Student Names:");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"{i}: {students[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentCollection studentCollection = new StudentCollection(5);

        // Adding student names using the indexer
        studentCollection[0] = "Alice";
        studentCollection[1] = "Bob";
        studentCollection[2] = "Charlie";
        studentCollection[3] = "David";
        studentCollection[4] = "Eve";

        // Displaying student names using the indexer
        studentCollection.Display();
    }
}
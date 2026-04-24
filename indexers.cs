/*
What are indexers in C#?
Indexers allow instances of a class or struct to be accessed like arrays using an integer or string index.
They provide a way to access elements of a collection using the [] operator.


Example of indexers in C#:
*/

class Student
{
    private string[] names = new string[5];

    // Indexer declaration
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }


    /*
    We cant use foreach dirextly so we return an getter of length to be able to use in normal for loop
    */
    public int length
    {
        get { return names.Length; }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        // Using the indexer to set values
        student[0] = "Alice";
        student[1] = "Bob";
        student[2] = "Charlie";

        // Using the indexer to get values
        Console.WriteLine(student[0]); // Output: Alice
        Console.WriteLine(student[1]); // Output: Bob
        Console.WriteLine(student[2]); // Output: Charlie



        /*
        Using foreach in indexers:

        Can we use foreach loop with indexers?
        No, we cannot use a foreach loop directly with indexers because indexers do not implement the IEnumerable interface.

        We should make a getter of length and use the normal for loop for indexers.
        */
        for (int i = 0; i < student.length; i++)
        {
            Console.WriteLine(student[i]);
        }



    }
}

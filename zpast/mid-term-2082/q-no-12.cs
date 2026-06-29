class StudentCollectin
{    
    List<string> students = new List<string>();

    public int Count
    {
        get { return students.Count; }
    }

    public string this[int index]
    {
        get { return students[index]; }
        set { students[index] = value; }
    }
}

class Solution
{
    static void Main(string[] args)
    {
        StudentCollection sc = new StudentCollection();
        sc[0] = "Ram";
        sc[1] = "Shyam";
        sc[2] = "Hari";

        Console.WriteLine("Students in the collection:");
        for (int i = 0; i < sc.Count; i++)
        {
            Console.WriteLine(sc[i]);
        }
    }
}

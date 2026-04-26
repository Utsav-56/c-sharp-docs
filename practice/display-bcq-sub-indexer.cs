/*
WAP to show bca 5th sem subjects with indexers
*/

class Subjects
{

    private List<string> subjectList;

    public Subjects()
    {
        subjectList = new List<string>();
    }

    public string this[int index]
    {
        get { return subjectList[index]; }
        set { subjectList.Insert(index, value); }
    }

    public void Display()
    {
        Console.WriteLine("BCA 5th Semester Subjects:");
        for (int i = 0; i < subjectList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {subjectList[i]}");
        }
    }



}

class Program
{
    static void Main(string[] args)
    {
        Subjects subjects = new Subjects();
        subjects[0] = "Data Structures";
        subjects[1] = "Database Management Systems";
        subjects[2] = "Operating Systems";
        subjects[3] = "Computer Networks";
        subjects[4] = "Software Engineering";

        subjects.Display();
    }
}
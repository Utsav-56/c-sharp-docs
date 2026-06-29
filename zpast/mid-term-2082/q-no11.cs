class Student {

    public int id;
    public string name;
    public int marks;

    public Student(int id,  string name, int marks){
        this.id = id;
        this.name = name;
        this.marks = marks;
    }
}

class Solution
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1, "Ram", 80),
            new Student(2, "Shyam", 60),
            new Student(3, "Hari", 95),
            new Student(4, "Sita", 70),
            new Student(5, "Gita", 85)
        };        

        // Using linq query filter students with marks greater than 75
        var filteredStudents = from student in students
                               where student.marks > 75
                               select student;

        Console.WriteLine("Students with marks greater than 75 (With Query syntax):");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"Id: {student.id}, Name: {student.name}, Marks: {student.marks}");
        }

        // Using linq method syntax filter students with marks greater than 75
        var filteredStudentsMethod = students.Where(student => student.marks > 75);
        Console.WriteLine("Students with marks greater than 75 (With Method syntax):");
        foreach (var student in filteredStudentsMethod)
        {
            Console.WriteLine($"Id: {student.id}, Name: {student.name}, Marks: {student.marks}");
        }
    }
}
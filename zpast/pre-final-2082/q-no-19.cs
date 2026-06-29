// StudentDb

using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
           @"Server=localhost;Database=LibraryDb;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True;";


    static T input<T>(string msg)
    {
        Console.Write(msg);
        return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }

    static void print(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Main(string[] args)
    {
        print(@"
        1. Add Student
        2. Add Course
        3. Add Enrollment
        4. Display Students
        5. Exit
        ");

        var choice = input<int>("Enter your choice");

        Action action = choice switch
        {
            1 => AddStudent,
            2 => AddCourse,
            3 => AddEnrollment,
            4 => DisplayStudent,
            5 => () => Environment.Exit(0),
            _ => () => print("Wrong input")
        };

        action();
    }

    static void run(SqlCommand cmd)
    {
        SqlConnection con = new SqlConnection(connectionString);
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    static void AddStudent()
    {

        var name = input<string>("Enter student name");

        string query = "INSERT INTO Students VALUE(@name)";

        SqlCommand cmd = new SqlCommand(query);
        cmd.Parameters.AddWithValue("@name", name);

        run(cmd);
        print("Student added...");
    }

    static void AddCourse()
    {
        var name = input<string>("Enter Course name");
        var query = "INSERT INTO Courses VALUES(@name)";

        SqlCommand cmd = new SqlCommand(query);
        cmd.Parameters.AddWithValue("@name", name);

        run(cmd);
        print("Course added....");
    }
    static void AddEnrollment()
    {
        var studentId = input<int>("Enter Student Id");
        var courseId = input<int>("Enter Course Id enrolled ");

        var query = "INSERT INTO Enrollments VALUES(@sid,@cid)";
        SqlCommand cmd = new SqlCommand(query);

        cmd.Parameters.AddWithValue("@sid", studentId);
        cmd.Parameters.AddWithValue("@cid", courseId);

        run(cmd);
        print("Enrollment added...");
    }
    static void DisplayStudent()
    {
        SqlConnection con = new SqlConnection(connectionString);

        var query = @"
        SELECT s.Name, c.Name
        FROM Enrollments e
        JOIN Students s ON e.StudentID = s.StudentID
        JOIN Courses c ON e.CourseID = c.CourseID
        ";

        SqlCommand cmd = new SqlCommand(query);
        cmd.Connection = con;

        con.Open();

        var reader = cmd.ExecuteReader();

        print("\n Students \t\t Enrolled Course");
        while (reader.Read())
        {
            print($"{reader[0]} \t\t {reader[1]}");
        }

        reader.Close();
        con.Close();
    }
}
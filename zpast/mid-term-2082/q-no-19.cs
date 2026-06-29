// LibraryDb


using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
    @"Server=localhost;Database=LibraryDb;User Id=sa;Password=YourStrongPassword123!;TrustServerCertificate=True;";

    static T Input<T>(string msg)
    {
        Console.Write(msg);
        return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }

    static void print(string message)
    {
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(@"
            1. Add Books
            2. Add Authors
            3. Display Books
            4. Exit
        ");

        var choice = Input<int>("Enter your choice: ");

        Action action = choice switch
        {
            1 => AddBook,
            2 => AddAuthor,
            3 => DisplayBooks,
            4 => () => Environment.Exit(0),
            _ => () => Console.WriteLine(choice + " Is not a valid option")
        };

        action(); // Run the selected action
    }

    static void Execute(SqlCommand cmd)
    {
        SqlConnection con = new SqlConnection(connectionString);
        cmd.Connection = con;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    static void AddBook()
    {
        var name = Input<string>("Enter book name: ");
        var authorId = Input<int>("Enter Author id: ");

        string query = "INSERT INTO Books(name,authorId) VALUES(@name, @authorId)";
        SqlCommand cmd = new SqlCommand(query);

        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@authorId", authorId); 

        Execute(cmd);
        print("Book added...");
    }

    static void AddAuthor()
    {
        var name = Input<string>("Enter Author name: ");

        string query = "INSERT INTO Authors(name) VALUES(@name)";
        SqlCommand cmd = new SqlCommand(query);
        cmd.Parameters.AddWithValue("@name", name);

        Execute(cmd);
        print($"Writer {name} info added successfully");
    }

    static void DisplayBooks()
    {
        SqlConnection con = new SqlConnection(connectionString);

        string query = @"
            SELECT b.Name, a.Name
            FROM Books b JOIN Authors a ON b.AuthorId=a.Id
            ORDER BY b.Name";

        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        print("\n Books \t\t Author");
        while (reader.Read())
        {
            print($"{reader[0]} \t\t {reader[1]}");
        }

        reader.Close();
        con.Close();
    }
}
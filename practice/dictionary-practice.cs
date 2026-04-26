/*
Wap to store details of a employee and display them using a dictionary.
*/

using System.Collections.Generic;
class Program
{

    private static void print(string msg)
    {
        Console.WriteLine(msg);
    }

    public static void Main(string[] args)
    {

        int n;

        if (!int.TryParse(Console.ReadLine(), out n))
        {
            print("Invalid input. Please enter a valid number.");
            return;
        }

        Dictionary<string, string>[] employees = new Dictionary<string, string>[n];

        for (int i = 0; i < n; i++)
        {
            employees[i] = new Dictionary<string, string>();

            print("Name: ");
            employees[i]["Name"] = Console.ReadLine();

            print("ID: ");
            employees[i]["ID"] = Console.ReadLine();

            print("Department: ");
            employees[i]["Department"] = Console.ReadLine();
        }

        print("\nEmployee Details:");
        for (int i = 0; i < n; i++)
        {
            print($"Name: {employees[i]["Name"]}");
            print($"ID:  {employees[i]["ID"]}");
            print($"Department: {employees[i]["Department"]}");
        }
    }

}
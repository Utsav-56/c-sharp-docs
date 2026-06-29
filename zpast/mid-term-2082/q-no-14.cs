using System;

enum FilePermissions
{
    Read = 1,
    Write = 2,
    Execute = 4
}

class Program
{
    static void Main()
    {
        Console.Write("Enter permission (1, 2 or 4): ");
        int value = Convert.ToInt32(Console.ReadLine());

    
        if (Enum.IsDefined(typeof(FilePermissions), value))
        {
            FilePermissions permission = (FilePermissions)value;
            Console.WriteLine("Permission Level: " + permission);        
        } else
        {
            Console.WriteLine("Invalid permission level.");
        }
    }
}
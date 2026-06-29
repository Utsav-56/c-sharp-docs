class Program
{

    delegate void MessageDelegate(string msg);


    static void Greet(string name)
    {
        Console.WriteLine($"Namaste {name} !");
    }

    static void Curse(string name)
    {
        Console.WriteLine($"Go to hell {name}");
    }

    static void Rip(string name)
    {
        Console.WriteLine($"RIP! {name}");
    }


    static void Main(string[] args)
    {

        MessageDelegate msg = Greet;
        msg += Curse;
        msg += Rip;

        msg("Ram");
    }
}
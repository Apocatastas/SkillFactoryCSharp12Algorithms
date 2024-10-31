using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        string greetings = "Привет, " + name;
        Console.WriteLine(greetings);
    }
}
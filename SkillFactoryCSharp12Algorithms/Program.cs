using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Сколько элементов будет в массиве?");
        int count = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("Все элементы записаны!");
    }
}
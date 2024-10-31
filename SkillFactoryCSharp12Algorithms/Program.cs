using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите свой возраст");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 13)
        {
            Console.WriteLine("Вы успешно зарегистрированы");
        }
        else
        {
            Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
        }
    }
}
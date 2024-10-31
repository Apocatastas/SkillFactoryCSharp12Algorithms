using System;
namespace SkillFactoryCSharp12Algorithms
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<User> userList = new List<User>();
			GetUserList(userList);
			foreach (User user in userList)
			{
				Console.WriteLine("Привет, " + user.Name);
				if (!user.IsPremium)
				{
					ShowAds();
				}
			}
			Console.ReadKey();
		}

		public static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			Thread.Sleep(1000);
			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			Thread.Sleep(2000);
			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			Thread.Sleep(3000);
		}

		public static void GetUserList(List<User> list)
		{
			Console.WriteLine("Введите количество пользователей");
			int userCount = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < userCount; i++)
			{
				Console.WriteLine("Введите логин пользователя");
				string login = Console.ReadLine();
				Console.WriteLine("Введите имя пользователя");
				string name = Console.ReadLine();
				bool status = GetSubscription();
				list.Add(new User(login, name, status));
			}
		}

		public static bool GetSubscription()
		{
            Console.WriteLine("Введите статус пользователя - 1 для премиум, 0 для обычной");
            string data = Console.ReadLine();
            if (data == "1") return true;
			if (data == "0") return false;
			Console.WriteLine("Ошибка! Убедитесь, что вы ввели 1 или 0");
			return GetSubscription();
        }
	}
}
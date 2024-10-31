using System;
namespace SkillFactoryCSharp12Algorithms
{
    class MainClass
    {
        public void Main(string[] args)
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
        }

        public void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }

        public void GetUserList(List<User> list)
        {
            Console.WriteLine("Введите количество пользователей");
            int userCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine("Введите логин пользователя");
                string login = Console.ReadLine();
                Console.WriteLine("Введите имя пользователя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите статус пользователя");
                bool status = Convert.ToBoolean(Console.ReadLine());
                list.Add(new User(login, name, status));
            }
        }
    }
}
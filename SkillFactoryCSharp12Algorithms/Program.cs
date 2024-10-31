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

        }
    }
}
using System;
namespace SkillFactoryCSharp12Algorithms
{
	public class User
	{
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool status)
        {
            Login = login;
            Name = name;
            IsPremium = status;
        }
	}
}


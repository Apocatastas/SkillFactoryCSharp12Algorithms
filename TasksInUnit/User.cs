using System;

namespace TasksInUnit
{
	public class User
	{
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public bool LoggedIn { get; set; }
        public bool HasAccessToSection { get; set; }
        public bool HasUnseenNews { get; set; }
        public bool HasAdminRights { get; set; }

        public User(string login, string name, bool status)
        {
            Login = login;
            Name = name;
            IsPremium = status;
        }
	}
}


using System;
namespace Class
{
	public class User
	{
		public string name;
		public string surname;
		public int age;
		private string password;

		public User(string name,string surname,int age)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
		}

		public void Set(string password)
		{
			this.password = password;
		}

		public string Get()
		{
			return password;
		}

	}
}


using System;
using ClassWork.Models;

namespace ClassWork.Services
{
	public class AccountService
	{
		public User CheckByEmailAndPasword(User[] users,string email,string password)
		{
			return users.FirstOrDefault(m => m.email == email && m.password == password);
		}
	}
}


using System;
using ClassWork.Services;

namespace ClassWork.Controllers
{
	public class AccountController
	{
		public void CheckByEmailAndPassword()
		{
			AccountService accountService = new();
			UserService users = new();
			Start: Console.WriteLine("Enter email");
			string email = Console.ReadLine().Trim();
			Console.WriteLine("Enter password");
			string password = Console.ReadLine().Trim();
			var result = accountService.CheckByEmailAndPasword(users.GetAll(), email, password);
			if (result==null)
			{
				Console.WriteLine("Email or Password is wrong");
				goto Start;
			}
			else
			{
				Console.WriteLine("Login Succes");
            }
						
		}
	}
}


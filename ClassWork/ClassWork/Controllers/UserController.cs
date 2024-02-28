using System;
using ClassWork.Models;
using ClassWork.Services;

namespace ClassWork.Controllers
{
	public class UserController
	{
		private readonly UserService userService;
		public UserController()
		{
			userService = new();
		}

		public void GetAll()
		{
			var users=userService.GetAll();
			foreach (var item in users)
			{
				Console.WriteLine($"Id:{item.id} Fullname:{item.fullName} Age:{item.age} Email:{item.email} Password:{item.password}");
			}
		}
		public void GetById()
		{
			Start: Console.WriteLine("Enter id");
			if(!int.TryParse(Console.ReadLine(),out int a))
			{
				Console.WriteLine("Enter correct id"); goto Start;
			}
			var result = userService.GetById(userService.GetAll(), a);
			if (result!=null)
			{
                Console.WriteLine($"Id:{result.id} Fullname:{result.fullName} Age:{result.age} Email:{result.email} Password:{result.password}");
				return;
			}
			{
				Console.WriteLine("Id doesnt exist"); goto Start;
			}

        }
	}
}



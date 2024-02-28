using System;
using ClassWork.Models;

namespace ClassWork.Services
{
    public class UserService
    {
        public User [] GetAll()
        {
            User user1 = new()
            {

                id = 1,
                fullName = "Ilgar Shiriyev",
                age = 26,
                email = "shiriyev@gmail.com",
                password = "shiriyev23"

            };
            User user2 = new()
            {

                id = 2,
                fullName = "Orxan Aliyev",
                age = 22,
                email = "aliyev@gmail.com",
                password = "aliyev99"

            };
            User user3 = new()
            {

                id = 3,
                fullName = "Nermin Agayeva",
                age = 17,
                email = "nermin@gmail.com",
                password = "nermin123"

            };
            User [] users = { user1, user2, user3 };
            return users;
        }

      public User GetById(User[]users,int id)
      {
            return users.FirstOrDefault(m => m.id == id);
      }
    }

}
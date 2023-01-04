using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApi6.Models;

namespace WebApplicationApi6.Services
{
    public class UserService
    {
        public List<User> getAllUsers()
        {
            var users = new List<User>();

            var user1 = new User
            {
                Id = 1,
                Name = "shehan",
                Email = "shehan@gmail.coom",
                Password = "1236",
                DateCreated = DateTime.Now,
                Staus = UserStatus.Inprogress
            };
            users.Add(user1);

            var user2 = new User
            {
                Id = 2,
                Name = "shehan2",
                Email = "shehan2@gmail.coom",
                Password = "12362",
                DateCreated = DateTime.Now,
                Staus = UserStatus.Completed
            };
            users.Add(user2);
            var user3 = new User
            {
                Id = 3,
                Name = "shehan3",
                Email = "shehan3@gmail.coom",
                Password = "12363",
                DateCreated = DateTime.Now,
                Staus = UserStatus.New
            };
            users.Add(user3);

            return users;
        }
    }
}

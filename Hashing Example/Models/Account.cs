using Hashing_Example.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_Example.Models
{
    public class Account
    {
        public Account()
        {
            accountService = new AccountService();
            Users = new List<User>();
        }

        private readonly AccountService accountService;

        private List<User> Users { get; set; }

        public void Register(string name, string password)
        {
            var user = Users.FirstOrDefault(x => x.Name == name);

            if (user == null)
            {
                var passwordHash = accountService.GetHash(password);

                User newUser = new User
                {
                    Name = name,
                    Password = passwordHash
                };

                Users.Add(newUser);

                Console.ForegroundColor
                    = ConsoleColor.Green;

                Console.WriteLine("\nSuccessfully Registered!\n");

                Console.ForegroundColor
                    = ConsoleColor.Gray;
            }
        }

        public void GetUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"$Name - {user.Name}\n" + 
                    $"$Password - {user.Password}");
            }
        }
    }
 
}

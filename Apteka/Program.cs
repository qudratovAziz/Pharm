using Apteka.Enums;
using Apteka.IRepositories;
using Apteka.Models;
using Apteka.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mock data
            //User user1 = new User()
            //{
            //    FirstName = "Umar",
            //    LastName = "Kamolov",
            //    Login = "qwerty",
            //    Password = "123456",
            //    Role = UserRole.User

            //};
            #endregion
            IUserRepository userRepo = new UserRepository();
            //var result = userRepo.Create(user1);

            Console.Write("Login: ");
            string login = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine();


            User result = userRepo.Login(login, password);
            if (result == null)
                Console.WriteLine("yoq");
            else
                Console.WriteLine(result.ToString());

            
        }
    }
}

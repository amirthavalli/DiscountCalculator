using DiscountCalculator.Data.Interface;
using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator.Data.Repository
{
    public class UserService : IUserService
    {
        public User GetUserInput()
        {
            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Password: ");
            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password.Substring(0, password.Length - 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            User user = new User();
            user.UserName = userName;
            user.Password = password;

            return user;
        }

        public bool ValidateUserInput(User userInput)
        {
            if (userInput.UserName == null || userInput.UserName == string.Empty || userInput.Password == null || userInput.Password == string.Empty)
            {
                Console.Clear();
                Console.WriteLine("Username or Password cannot be empty!!");
                return false;
            }
            return true;
        }
    }
}

using DiscountCalculator.Data.Interface;
using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator.Data.Repository
{
    public class LoginService : ILoginService
    {
        private DataTable User;
        public static bool isValidUser = false;

        public LoginService()
        {
            User = new DataTable("User");
            User.Columns.Add("Name");
            User.Columns.Add("Password");

            User.Rows.Add("default", "password");
        }

        public bool AuthenticateUser(User userInput)
        {
            if (User.Select("Name = '" + userInput.UserName + "' and Password = '" + userInput.Password + "'").Count() > 0)
            {
                Console.Clear();
                isValidUser = true;
                return true;
            }
            return false;
        }

        
    }
}

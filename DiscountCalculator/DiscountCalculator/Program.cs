using DiscountCalculator.Data.Interface;
using DiscountCalculator.Data.Repository;
using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program startApplication = new Program();
            Console.WriteLine("Please enter your credentials! ");
            startApplication.Login();
        }

        private void Login()
        {
            ILoginService login = new LoginService();
            IUserService userService = new UserService();
            User userInput = userService.GetUserInput();

            bool isInputValid = userService.ValidateUserInput(userInput);
            if(isInputValid)
            {
                bool isValidUser = login.AuthenticateUser(userInput);
                if (!isValidUser)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Username or Password!! Please try again!!");
                    Login();
                }
                else
                {
                    PerformCalculation();
                }
            }
            else
            { Login(); }
        }

        private void PerformCalculation()
        {
            ICalculationService calculationHelper = new CalculationService();
            var input = calculationHelper.GetCalculatorInput();

            GoldPriceCalculator goldPriceCalculator = new GoldPriceCalculator();
            decimal totalPrice = goldPriceCalculator.CalulateGoldPrice(input);

            Console.WriteLine("Total Price after Discount: " + totalPrice);
            Console.WriteLine("Press any key to calculate again!! (Press Esc to exit)");

            var inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Escape)
                Environment.Exit(1);
            else
                PerformCalculation();
        }
        

    }
}

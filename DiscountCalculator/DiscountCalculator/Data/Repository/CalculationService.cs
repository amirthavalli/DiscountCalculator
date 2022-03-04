using DiscountCalculator.Data.Interface;
using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator
{
    public class CalculationService : ICalculationService
    {
        public Input GetCalculatorInput()
        {
            try
            {

                Input input = new Input();

            Price:
                Console.WriteLine("Enter Gold Price: ");

                if (!Decimal.TryParse(Console.ReadLine(), out decimal price))
                {
                    Console.WriteLine("Gold Price has to be Numeric! ");
                    goto Price;
                }

            Weight:
                Console.WriteLine("Enter weight of gold: ");

                if (!Decimal.TryParse(Console.ReadLine(), out decimal weight))
                {
                    Console.WriteLine("Weight of gold has to be Numeric! ");
                    goto Weight;
                }
                if (weight < 0)
                    throw new ArgumentException("Weight cannot be Negative!!");

                Discount:
                Console.WriteLine("Enter Discount: ");

                if (!Decimal.TryParse(Console.ReadLine(), out decimal discount))
                {
                    Console.WriteLine("Discount has to be Numeric! ");
                    goto Discount;
                }

                input.Price = price;
                input.Weight = weight;
                input.Discount = discount;

                return input;

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to try again!! Press Esc to exit!");
                var inputKey = Console.ReadKey();
                if (inputKey.Key != ConsoleKey.Escape)
                    GetCalculatorInput();
                else
                    Environment.Exit(1);
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

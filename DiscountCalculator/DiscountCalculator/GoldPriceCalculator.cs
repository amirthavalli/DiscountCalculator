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
    public class GoldPriceCalculator : Calculator
    {
        public decimal CalulateGoldPrice(Input input)
        {
            if (LoginService.isValidUser)
                return CalculateTotalPrice(input);
            else
                throw new UnauthorizedAccessException("Kindly login to use the calculator !!");
        }
    }
}

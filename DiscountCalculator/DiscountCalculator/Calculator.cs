using DiscountCalculator.Data.Interface;
using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator
{
    public class Calculator
    {
        protected decimal CalculateTotalPrice(Input calculatorInput)
        {
            try
            {
                if (calculatorInput.Price == decimal.Zero || calculatorInput.Weight == decimal.Zero)
                    return decimal.Zero;
                else
                {
                    decimal totalPrice = calculatorInput.Price * calculatorInput.Weight;
                    if (calculatorInput.Discount == null || calculatorInput.Discount == decimal.Zero)
                        return totalPrice;
                    else
                    {
                        decimal discountedPrice = totalPrice - ((calculatorInput.Discount ?? decimal.Zero) / 100 * totalPrice);
                        return discountedPrice;
                    }
                       
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
    }
}

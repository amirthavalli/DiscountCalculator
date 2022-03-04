using DiscountCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculator.Data.Interface
{
    interface IUserService
    {
        User GetUserInput();
        bool ValidateUserInput(User userInput);
    }
}

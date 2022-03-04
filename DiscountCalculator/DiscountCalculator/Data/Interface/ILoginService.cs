
using DiscountCalculator.Model;

namespace DiscountCalculator.Data.Interface
{
    public interface ILoginService
    {
        bool AuthenticateUser(User userInput);
    }
}

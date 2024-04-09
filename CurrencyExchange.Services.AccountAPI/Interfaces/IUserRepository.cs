using CurrencyExchange.Services.AccountAPI.Models;
using Services.UserService.Models;

namespace CurrencyExchange.Services.AccountAPI.Interfaces
{
    public interface IUserRepository
    {
        User Login(string accountUsername, string accountPassword);
    }
}

using CurrencyExchange.Services.AccountAPI.Models;

namespace CurrencyExchange.Services.AccountAPI.Interfaces
{
    public interface IAccountRepository
    {
        Account Login(string accountUsername, string accountPassword);
    }
}

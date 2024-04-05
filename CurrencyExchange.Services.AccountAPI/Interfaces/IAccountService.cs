using CurrencyExchange.Services.AccountAPI.Models;

namespace CurrencyExchange.Services.AccountAPI.Interfaces
{
    public interface IAccountService
    {
        Account Login(string accountUsername, string accountPassword);   
    }
}

using CurrencyExchange.Services.AccountAPI.Interfaces;
using CurrencyExchange.Services.AccountAPI.Models;

namespace CurrencyExchange.Services.AccountAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account Login(string accountUsername, string accountPassword)
        {
            var returnData = _accountRepository.Login(accountUsername, accountPassword);
            
            return returnData;
        }
    }
}

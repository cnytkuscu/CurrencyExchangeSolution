using CurrencyExchange.Services.AccountAPI.Interfaces;
using CurrencyExchange.Services.AccountAPI.Models;

namespace CurrencyExchange.Services.AccountAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public Account Login(string accountUsername, string accountPassword)
        {
            return _context.Accounts.FirstOrDefault(x => x.AccountPassword == accountPassword && x.AccountUsername == accountUsername);
        }
    }
}

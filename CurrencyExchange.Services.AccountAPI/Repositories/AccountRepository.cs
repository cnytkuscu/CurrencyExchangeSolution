using CurrencyExchange.Services.AccountAPI.Interfaces;
using CurrencyExchange.Services.AccountAPI.Models;
using Services.UserService.Models;

namespace CurrencyExchange.Services.AccountAPI.Repositories
{
    public class AccountRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Login(string accountUsername, string accountPassword)
        {
            return _context.Users.FirstOrDefault(x => x.Password == accountPassword && x.Username == accountUsername);
        }

         
    }
}

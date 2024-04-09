using Common.Enums;
using CurrencyExchange.Services.AccountAPI.Models;
using UserService.Models;

namespace Services.UserService.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string OwnerName { get; set; }
        public bool IsActive { get; set; }


        public ICollection<AccountBalance> AccountBalances { get; set; }
        public ICollection<LoginRecord> LoginRecords { get; set; }
        public ICollection<AccountHistory> AccountHistories { get; set; }



    }
}

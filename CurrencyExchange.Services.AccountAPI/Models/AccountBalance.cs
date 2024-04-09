using CurrencyExchange.Services.AccountAPI.Models;
using Services.UserService.Models;

namespace UserService.Models
{
    public class AccountBalance : BaseEntity
    {
        public Guid AccountId { get; set; }
        public decimal Balance { get; set; }
        public string CurrencyCode { get; set; }

        public User Account { get; set; }
    }
}

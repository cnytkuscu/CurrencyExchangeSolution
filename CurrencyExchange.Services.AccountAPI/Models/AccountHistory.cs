using Common.Enums;
using Services.UserService.Models;

namespace CurrencyExchange.Services.AccountAPI.Models
{
    public class AccountHistory : BaseEntity
    {
        public ProcessType ProcessType { get; set; }
        public string Definition { get; set; }
        public Guid AccountId { get; set; }

        public User User { get; set; }

    }
}

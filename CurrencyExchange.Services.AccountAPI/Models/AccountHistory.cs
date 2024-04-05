using Common.Enums;

namespace CurrencyExchange.Services.AccountAPI.Models
{
    public class AccountHistory : BaseEntity
    {
        public ProcessType ProcessType { get; set; }
        public string Definition { get; set; }
        public Guid AccountId { get; set; }

        public Account Account { get; set; }

    }
}

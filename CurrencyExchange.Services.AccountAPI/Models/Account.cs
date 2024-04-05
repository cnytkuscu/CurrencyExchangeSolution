using Common.Enums;

namespace CurrencyExchange.Services.AccountAPI.Models
{
    public class Account : BaseEntity
    {
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public CurrencyType CurrencyCode { get; set; }
        public bool IsActive { get; set; }


        public ICollection<LoginRecord> LoginRecords { get; set; }
        public ICollection<AccountHistory> AccountHistories { get; set; }



    }
}

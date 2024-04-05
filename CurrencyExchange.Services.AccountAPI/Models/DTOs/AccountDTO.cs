using Common.Enums;

namespace CurrencyExchange.Services.AccountAPI.Models.DTOs
{
    public class AccountDTO : BaseDTO
    {
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        //public string CurrencyCode { get; set; }
        //public int CurrencyNumber { get; set; }
        public bool IsActive { get; set; }
    }
}

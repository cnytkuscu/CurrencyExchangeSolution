namespace CurrencyExchange.Services.AccountAPI.Models
{
    public class LoginRecord : BaseEntity
    {
        public string LoginIP { get; set; }
        public string LoginLocation { get; set; }
        public DateTime LoginDate { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}

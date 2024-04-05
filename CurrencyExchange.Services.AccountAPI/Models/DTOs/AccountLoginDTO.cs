using System.ComponentModel.DataAnnotations;

namespace CurrencyExchange.Services.AccountAPI.Models.DTOs
{
    public class AccountLoginDTO : BaseDTO
    {
        [Required]
        public string AccountUsername { get; set; }
        [Required]
        public string AccountPassword { get; set; }
    }
}

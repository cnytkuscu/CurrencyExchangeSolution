using CurrencyExchange.Services.AccountAPI.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace UserService.Models.DTOs
{
    public class RegisterDTO : BaseDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string OwnerName { get; set; }
    }
}

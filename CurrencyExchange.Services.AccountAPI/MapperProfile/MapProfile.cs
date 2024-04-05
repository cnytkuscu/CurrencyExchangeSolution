using AutoMapper;
using CurrencyExchange.Services.AccountAPI.Models;
using CurrencyExchange.Services.AccountAPI.Models.DTOs;

namespace CurrencyExchange.Services.AccountAPI.MapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Account, AccountDTO>().ReverseMap();
            CreateMap<Account, AccountLoginDTO>().ReverseMap();
        }
    }
}

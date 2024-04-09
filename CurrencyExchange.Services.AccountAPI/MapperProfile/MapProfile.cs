using AutoMapper;
using CurrencyExchange.Services.AccountAPI.Models;
using CurrencyExchange.Services.AccountAPI.Models.DTOs;
using Services.UserService.Models;
using UserService.Models.DTOs;

namespace CurrencyExchange.Services.AccountAPI.MapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, AccountDTO>().ReverseMap();
            CreateMap<User, AccountLoginDTO>().ReverseMap();
            CreateMap<User, RegisterDTO>().ReverseMap();
        }
    }
}

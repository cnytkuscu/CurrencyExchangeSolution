using AutoMapper;
using CurrencyExchange.Services.AccountAPI.Interfaces;
using CurrencyExchange.Services.AccountAPI.Models;
using CurrencyExchange.Services.AccountAPI.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.UserService.Models;
using UserService.Models.DTOs;

namespace CurrencyExchange.Services.AccountAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<User> _service;
        private readonly IGenericService<LoginRecord> _loginRecordGenericService;
        private readonly IGenericService<AccountHistory> _accountHistoryService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IMapper mapper, IGenericService<User> service, IUserService userService, IGenericService<LoginRecord> loginRecordGenericService, IHttpContextAccessor httpContextAccessor, IGenericService<AccountHistory> accountHistoryService)
        {
            _mapper = mapper;
            _service = service;
            _userService = userService;
            _loginRecordGenericService = loginRecordGenericService;
            _httpContextAccessor = httpContextAccessor;
            _accountHistoryService = accountHistoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accounts = await _service.GetAllAsync();
            var accountsDTO = _mapper.Map<List<AccountDTO>>(accounts.ToList());
            return Ok(accountsDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] AccountLoginDTO accountDTO)
        {
            if (accountDTO == null
                || string.IsNullOrEmpty(accountDTO.AccountUsername)
                || string.IsNullOrEmpty(accountDTO.AccountPassword))
            {
                return BadRequest();
            }

            var loginResult = _userService.Login(accountDTO.AccountUsername, accountDTO.AccountPassword);

            if (loginResult == null)
            {
                return NotFound();
            }
            else
            {
                var loginRecordResult = await _loginRecordGenericService.AddAsync(
                    new LoginRecord()
                    {
                        LoginIP = _httpContextAccessor.HttpContext.Request.Host.Value,
                        LoginLocation = "Turkey",
                        LoginDate = DateTime.Now,
                        AccountId = loginResult.Id,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now
                    });

                var accountHistoryResult = await _accountHistoryService.AddAsync(new AccountHistory()
                {
                    ProcessType = Common.Enums.ProcessType.Login,
                    Definition = "User Logged in.",
                    AccountId = loginResult.Id,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                });

                var accountDTOMap = _mapper.Map<User>(loginResult);

                return Ok(accountDTOMap);
            }

        } 

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterDTO accountDTO)
        {
            if (accountDTO == null
                || string.IsNullOrEmpty(accountDTO.Username)
                || string.IsNullOrEmpty(accountDTO.Password)
                || string.IsNullOrEmpty(accountDTO.OwnerName))
            {
                return BadRequest();
            }

            var userModel = _mapper.Map<User>(accountDTO);
            userModel.IsActive = true;

            var registerResult = await _service.AddAsync(userModel);

            return Ok(registerResult);

        }
    }
}

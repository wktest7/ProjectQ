using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectQ.Infrastructure.Commands.Users;
using ProjectQ.Infrastructure.DTO;
using ProjectQ.Infrastructure.Services;

namespace ProjectQ.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public async Task<UserDTO> Get(string email)
        {
            return await _userService.GetAsync(email);
        }

        [HttpPost("")]
        public async Task Post([FromBody]CreateUser request)
        {
            await _userService.RegisterAsync(request.Email, request.UserName, request.Password);
        }


    }
}

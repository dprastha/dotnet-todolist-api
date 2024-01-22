using System.Net;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using TodoApi.Requests;
using TodoApi.Services;
using BC = BCrypt.Net.BCrypt;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserService userService) : ControllerBase
    {
        private readonly UserService _userService = userService;

        [HttpPost("register")]
        public async Task<ApiResponse> Register(AuthRegister register)
        {
            Console.WriteLine(register.ToJson());
            await _userService.Create(new Models.User()
            {
                Email = register.Email,
                FirstName = register.FirstName,
                LastName = register.LastName,
                Password = BC.HashPassword(register.Password),
            });

            return new ApiResponseData(HttpStatusCode.OK, null);
        }
    }
}
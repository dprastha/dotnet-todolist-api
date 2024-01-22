using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Requests;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // private readonly IAuthService _authService;

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(AuthRegister register)
        {
            return Ok();
        }
    }
}
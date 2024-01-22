using System.Net;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using TodoApi.Models;
using TodoApi.Requests;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController() : ControllerBase
    {

        [HttpPost("register")]
        public ApiResponse Register(AuthRegister register)
        {
            Console.WriteLine(register.ToJson());
            // userApplication.Register(register);

            return new ApiResponseData(HttpStatusCode.OK, null);
        }
    }
}
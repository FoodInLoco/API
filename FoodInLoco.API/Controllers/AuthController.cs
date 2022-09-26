using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SigInAsync(SignInModel signIn)
        {
            var tokenResult = await _authService.SignInAsync(signIn);
            if (tokenResult.Failed)
                return Unauthorized(tokenResult.Message);
            return Ok(tokenResult.Data);
        }
    }
}

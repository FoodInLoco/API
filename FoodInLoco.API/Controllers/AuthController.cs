using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignInAsync(SignInModel signIn)
        {
            var tokenResult = await _userService.SignInAsync(signIn);
            if (tokenResult.Failed)
                return Unauthorized(tokenResult.Message);
            return Ok(tokenResult.Data);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LoggedUser()
        {
            var userResult = await _userService.GetByEmail(User.Claims.Where(x => x.Type == ClaimTypes.Email).FirstOrDefault()?.Value);
            if (userResult == null)
                return Unauthorized();
            return Ok(userResult);
        }
    }
}

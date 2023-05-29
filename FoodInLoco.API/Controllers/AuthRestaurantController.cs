using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthRestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public AuthRestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignInAsync(SignInModel signIn)
        {
            var result = await _restaurantService.SignInAsync(signIn);
            if (result.Failed)
                return Unauthorized(result);
            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> LoggedUser()
        {
            var result = await _restaurantService.GetByEmail(User.Claims.Where(x => x.Type == ClaimTypes.Email).FirstOrDefault()?.Value);
            if (result == null)
                return Unauthorized();
            return Ok(result);
        }
    }
}

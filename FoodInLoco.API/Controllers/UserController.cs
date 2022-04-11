using FoodInLoco.Application.Contracts.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var users = await _userService.ListAsync();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet]
        [Route("get-user-by-id")]
        public async Task<IActionResult> GetUserById(long id)
        {
            var user = await _userService.GetAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(UserModel user)
        {
            var result = await _userService.AddAsync(user);
            if (result.Succeeded)
                return Created($"/get-user-by-id?id={user.Id}", user);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(UserModel userToUpdate)
        {
            var result = await _userService.UpdateAsync(userToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest();
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _userService.DeleteAsync(id);
            if (result.Succeeded)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}

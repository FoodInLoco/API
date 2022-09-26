using FoodInLoco.Application.Data.Models;
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
            var result = await _userService.ListAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _userService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(UserModel user)
        {
            var result = await _userService.AddAsync(user);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", result);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(UserModel userToUpdate)
        {
            var result = await _userService.UpdateAsync(userToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet]
        [Route("activate")]
        public async Task<IActionResult> ActivateById(long id)
        {
            var result = await _userService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("inactivate")]
        public async Task<IActionResult> InactivateById(long id)
        {
            var result = await _userService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            var result = await _userService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

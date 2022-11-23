using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _menuService.ListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByRestaurantAsync(Guid id)
        {
            var result = await _menuService.ListByRestaurantAsync(id);
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _menuService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MenuModel menu)
        {
            var result = await _menuService.AddAsync(menu);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", menu);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(MenuModel menuToUpdate)
        {
            var result = await _menuService.UpdateAsync(menuToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _menuService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _menuService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _menuService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

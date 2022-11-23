using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _menuItemService.ListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByMenuAsync(Guid id)
        {
            var result = await _menuItemService.ListByMenuAsync(id);
            return Ok(result);
        }

        [HttpPost("grid")]
        public async Task<IActionResult> GetGridAsync(GridParameters parameters)
        {
            var result = await _menuItemService.GridAsync(parameters);
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _menuItemService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MenuItemModel menuItem)
        {
            var result = await _menuItemService.AddAsync(menuItem);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", menuItem);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(MenuItemModel menuItemToUpdate)
        {
            var result = await _menuItemService.UpdateAsync(menuItemToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _menuItemService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _menuItemService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _menuItemService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

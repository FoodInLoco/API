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

        //[HttpGet]
        //public async Task<IActionResult> GetAsync()
        //{
        //    var result = await _menuItemService.ListAsync();
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("get-by-id")]
        //public async Task<IActionResult> GetById(long id)
        //{
        //    var result = await _menuItemService.GetAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpPost]
        //public async Task<IActionResult> PostAsync(MenuItemModel menuItem)
        //{
        //    var result = await _menuItemService.AddAsync(menuItem);
        //    if (result.Succeeded)
        //        return Created($"/get-by-id?id={menuItem.Id}", menuItem);
        //    return BadRequest();
        //}

        //[HttpPut]
        //public async Task<IActionResult> PutAsync(MenuItemModel menuItemToUpdate)
        //{
        //    var result = await _menuItemService.UpdateAsync(menuItemToUpdate);
        //    if (result.Succeeded)
        //        return NoContent();
        //    return BadRequest();
        //}

        //[HttpGet]
        //[Route("activate")]
        //public async Task<IActionResult> ActivateById(long id)
        //{
        //    var result = await _menuItemService.ActivateAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("inactivate")]
        //public async Task<IActionResult> InactivateById(long id)
        //{
        //    var result = await _menuItemService.InactivateAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[Route("{id}")]
        //[HttpDelete]
        //public async Task<IActionResult> DeleteAsync(long id)
        //{
        //    var result = await _menuItemService.DeleteAsync(id);
        //    if (result.Succeeded)
        //        return NoContent();
        //    return NotFound();
        //}
    }
}

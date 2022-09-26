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

        //[HttpGet]
        //public async Task<IActionResult> GetAsync()
        //{
        //    var result = await _menuService.ListAsync();
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("get-by-id")]
        //public async Task<IActionResult> GetById(long id)
        //{
        //    var result = await _menuService.GetAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpPost]
        //public async Task<IActionResult> PostAsync(MenuModel menu)
        //{
        //    var result = await _menuService.AddAsync(menu);
        //    if (result.Succeeded)
        //        return Created($"/get-by-id?id={menu.Id}", menu);
        //    return BadRequest();
        //}

        //[HttpPut]
        //public async Task<IActionResult> PutAsync(MenuModel menuToUpdate)
        //{
        //    var result = await _menuService.UpdateAsync(menuToUpdate);
        //    if (result.Succeeded)
        //        return NoContent();
        //    return BadRequest();
        //}

        //[HttpGet]
        //[Route("activate")]
        //public async Task<IActionResult> ActivateById(long id)
        //{
        //    var result = await _menuService.ActivateAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("inactivate")]
        //public async Task<IActionResult> InactivateById(long id)
        //{
        //    var result = await _menuService.InactivateAsync(id);
        //    if (result == null)
        //        return NotFound();
        //    return Ok(result);
        //}

        //[Route("{id}")]
        //[HttpDelete]
        //public async Task<IActionResult> DeleteAsync(long id)
        //{
        //    var result = await _menuService.DeleteAsync(id);
        //    if (result.Succeeded)
        //        return NoContent();
        //    return NotFound();
        //}
    }
}

using DotNetCore.Extensions;
using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Enums;
using FoodInLoco.Application.Extensions;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _restaurantService.ListAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("grid")]
        public async Task<IActionResult> GetGridAsync(GridParameters parameters)
        {
            var result = await _restaurantService.GridAsync(parameters);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _restaurantService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostAsync(RestaurantModelRequest obj)
        {
            var result = await _restaurantService.AddAsync(obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);

            return BadRequest(result);
        }

        [Authorize(Roles = "Restaurant")]
        [HttpPut]
        public async Task<IActionResult> PutAsync(RestaurantModelRequest objToUpdate)
        {
            if (!await _restaurantService.CheckUser(objToUpdate.Id, Guid.Parse(User.GetUserId())))
                return Unauthorized();

            var result = await _restaurantService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();

            return BadRequest(result);
        }

        [Authorize]
        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _restaurantService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _restaurantService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _restaurantService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

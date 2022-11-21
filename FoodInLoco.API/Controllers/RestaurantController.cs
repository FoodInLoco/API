using DotNetCore.Objects;
using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services;
using FoodInLoco.Application.Services.Interfaces;
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

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _restaurantService.ListAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("grid")]
        public async Task<IActionResult> GetGridAsync(GridParameters parameters)
        {
            var result = await _restaurantService.GridAsync(parameters);
            return Ok(result);
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _restaurantService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(RestaurantModel restaurant)
        {
            var result = await _restaurantService.AddAsync(restaurant);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", restaurant);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(RestaurantModel restaurantToUpdate)
        {
            var result = await _restaurantService.UpdateAsync(restaurantToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet]
        [Route("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _restaurantService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _restaurantService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _restaurantService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

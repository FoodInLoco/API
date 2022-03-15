using FoodInLoco.Application.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly Application.Data.FoodInLocoDb _dbContext;

    public RestaurantController(Application.Data.FoodInLocoDb dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var restaurant = await _dbContext.Restaurant.ToListAsync();
        if (restaurant == null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }

    [HttpGet]
    [Route("get-restaurant-by-id")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var restaurant = await _dbContext.Restaurant.FindAsync(id);
        return Ok(restaurant);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Restaurant restaurant)
    {
        _dbContext.Restaurant.Add(restaurant);
        await _dbContext.SaveChangesAsync();
        return Created($"/get-user-by-id?id={restaurant.Id}", restaurant);
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(Restaurant restaurantToUpdate)
    {
        _dbContext.Restaurant.Update(restaurantToUpdate);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }

    [Route("{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var restaurantToDelete = await _dbContext.Restaurant.FindAsync(id);
        if (restaurantToDelete == null)
        {
            return NotFound();
        }
        _dbContext.Restaurant.Remove(restaurantToDelete);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }
}
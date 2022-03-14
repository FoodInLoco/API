using FoodInLoco.Application.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodInLoco.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly Application.Data.FoodInLocoDb _dbContext;
    public UserController(Application.Data.FoodInLocoDb dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var cakes = await _dbContext.User.ToListAsync();
        return Ok(cakes);
    }

    [HttpGet]
    [Route("get-user-by-id")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var cake = await _dbContext.User.FindAsync(id);
        return Ok(cake);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(User user)
    {
        _dbContext.User.Add(user);
        await _dbContext.SaveChangesAsync();
        return Created($"/get-user-by-id?id={user.Id}", user);
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(User userToUpdate)
    {
        _dbContext.User.Update(userToUpdate);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }

    [Route("{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var cakeToDelete = await _dbContext.User.FindAsync(id);
        if (cakeToDelete == null)
        {
            return NotFound();
        }
        _dbContext.User.Remove(cakeToDelete);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }
}
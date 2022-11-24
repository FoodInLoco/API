using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttractionController : ControllerBase
    {
        private readonly IAttractionService _attractionService;

        public AttractionController(IAttractionService attractionService)
        {
            _attractionService = attractionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _attractionService.ListAsync();
            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _attractionService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(AttractionModelRequest obj)
        {
            var result = await _attractionService.AddAsync(obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(AttractionModelRequest objToUpdate)
        {
            var result = await _attractionService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _attractionService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _attractionService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _attractionService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

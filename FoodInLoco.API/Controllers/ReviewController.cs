using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _reviewService.ListAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _reviewService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ReviewModel obj)
        {
            var result = await _reviewService.AddAsync(obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(ReviewModel objToUpdate)
        {
            var result = await _reviewService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet]
        [Route("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _reviewService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _reviewService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _reviewService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

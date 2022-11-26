using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Extensions;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _reservationService.ListAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("get-by-restaurant")]
        public async Task<IActionResult> GetByRestaurantAsync(Guid restaurantId, DateTime? date)
        {
            var result = await _reservationService.ListByDateFromRestaurantAsync(restaurantId, date);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("get-by-user")]
        public async Task<IActionResult> GetByUserAsync(Guid userId, DateTime? date)
        {
            var result = await _reservationService.ListByDateFromUserAsync(userId, date);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _reservationService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostAsync(ReservationModelRequest obj)
        {
            Guid userId;
            var parsed = Guid.TryParse(User.GetUserId(), out userId);
            if (!parsed)
                return Unauthorized();
            var result = await _reservationService.AddAsync(userId, obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> PutAsync(ReservationModelRequest objToUpdate)
        {
            Guid userId;
            var parsed = Guid.TryParse(User.GetUserId(), out userId);
            if (!parsed || !await _reservationService.CheckUser(objToUpdate.Id, userId))
                return Unauthorized();
            var result = await _reservationService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _reservationService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _reservationService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("confirm")]
        public async Task<IActionResult> ConfirmById(Guid id)
        {
            var result = await _reservationService.ConfirmAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("disconfirm")]
        public async Task<IActionResult> DisconfirmById(Guid id)
        {
            var result = await _reservationService.DisconfirmAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _reservationService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _reservationService.ListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByRestaurantAsync(DateTime? date)
        {
            var result = await _reservationService.ListAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _reservationService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ReservationModel obj)
        {
            var result = await _reservationService.AddAsync(obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(ReservationModel objToUpdate)
        {
            var result = await _reservationService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [HttpGet]
        [Route("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _reservationService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _reservationService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("confirm")]
        public async Task<IActionResult> ConfirmById(Guid id)
        {
            var result = await _reservationService.ConfirmAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("disconfirm")]
        public async Task<IActionResult> DisconfirmById(Guid id)
        {
            var result = await _reservationService.DisconfirmAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _reservationService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

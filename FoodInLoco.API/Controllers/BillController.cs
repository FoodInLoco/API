using FoodInLoco.Application.Data.Models;
using FoodInLoco.Application.Extensions;
using FoodInLoco.Application.Services;
using FoodInLoco.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodInLoco.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _billService.ListAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _billService.GetAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("get-pending-users-by-id")]
        public async Task<IActionResult> GetPendingUsersById(Guid id)
        {
            var result = await _billService.GetUserPendingAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("get-active-bill-by-table-id")]
        public async Task<IActionResult> GetActiveBillByTableId(Guid id)
        {
            var result = await _billService.GetActiveByTableAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize(Roles = "User")]
        [HttpGet("get-active-bills")]
        public async Task<IActionResult> GetActiveBills()
        {
            var result = await _billService.GetActiveByUserAsync(Guid.Parse(User.GetUserId()));
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> PostAsync(BillModelRequest obj)
        {
            var result = await _billService.AddAsync(obj, Guid.Parse(User.GetUserId()));
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [Authorize]
        [HttpPost("post-user-bill")]
        public async Task<IActionResult> PostUserAsync(BillUserModelRequest obj)
        {
            var result = await _billService.AddUserAsync(obj);
            if (result.Succeeded)
                return Created($"/get-by-id?id={result.Data}", obj);
            return BadRequest(result);
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> PutAsync(BillModelRequest objToUpdate)
        {
            var result = await _billService.UpdateAsync(objToUpdate);
            if (result.Succeeded)
                return NoContent();
            return BadRequest(result);
        }

        [Authorize]
        [HttpGet("activate")]
        public async Task<IActionResult> ActivateById(Guid id)
        {
            var result = await _billService.ActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpGet("inactivate")]
        public async Task<IActionResult> InactivateById(Guid id)
        {
            var result = await _billService.InactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpPost("accept-user")]
        public async Task<IActionResult> AcceptUserById(BillUserModelRequest model)
        {
            var result = await _billService.AcceptUserAsync(model);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpPost("decline-user")]
        public async Task<IActionResult> DeclineUserById(BillUserModelRequest model)
        {
            var result = await _billService.DeclineUserAsync(model);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize(Roles = "User")]
        [HttpGet("request-waiter")]
        public async Task<IActionResult> RequestWaiterById(Guid id)
        {
            if (await _billService.CheckUser(id, Guid.Parse(User.GetUserId())))
                return Unauthorized();
            var result = await _billService.WaiterActivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize(Roles = "Restaurant")]
        [HttpGet("waiter-served")]
        public async Task<IActionResult> WaiterServedById(Guid id)
        {
            if (await _billService.CheckRestaurant(id, Guid.Parse(User.GetUserId())))
                return Unauthorized();
            var result = await _billService.WaiterInactivateAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _billService.DeleteAsync(id);
            if (result.Succeeded)
                return NoContent();
            return NotFound();
        }
    }
}

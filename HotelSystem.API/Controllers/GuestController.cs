using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Guest;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IPaymentService _basePaymentService;

        public GuestController(IGuestService guestService, IPaymentService basePaymentService)
        {
            _guestService = guestService;
            _basePaymentService = basePaymentService;
        }

        [HttpGet("GetGuests")]
        public async Task<IActionResult> GetGuests()
        {
            var response = await _guestService.GetAllAsync();
            return Ok(response.Data);
        }

        [HttpGet("GetGuestLastPayment")]
        public async Task<IActionResult> GetGuestPayments(uint guestId)
        {
            var response = await _basePaymentService.GuestLastPaymentByGuestIdAsync(guestId);
            return Ok(response.Data);
        }

        [HttpGet("GetGuestById")]
        public async Task<IActionResult> GetGuestById(uint Id)
        {
            var response = await _guestService.GetByIdAsync(Id);
            return Ok(response);
        }


        [HttpDelete("DeleteGuestById")]
        public async Task<IActionResult> DeleteGuestById(uint Id)
        {
            var response = await _guestService.DeleteByIdAsync(Id);
            return Ok(response);
        }

        [HttpPut("UpdateGuest")]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDTO model)
        {
            var response = await _guestService.UpdateAsync(model);
            return Ok(response);
        }


        [HttpPost("CreateGuest")]
        public async Task<IActionResult> CreateGuest(CreateGuestDTO model)
        {
            var response = await _guestService.CreateAsync(model);
            return Ok(response);
        }



    }
}

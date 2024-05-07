﻿using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Guest;
using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Room;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("GetRooms")]
        public async Task<IActionResult> GetRooms()
        {
            var response = await _roomService.GetAllAsync();
            return Ok(response.Data);
        }

        [HttpGet("GetRoomById")]
        public async Task<IActionResult> GetRoomById(uint Id)
        {
            var response = await _roomService.GetByIdAsync(Id);
            return Ok(response);
        }


        [HttpDelete("DeleteRoomById")]
        public async Task<IActionResult> DeleteRoomById(uint Id)
        {
            var response = await _roomService.DeleteByIdAsync(Id);
            return Ok(response);
        }

        [HttpPut("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDTO model)
        {
            var response = await _roomService.UpdateAsync(model);
            return Ok(response);
        }

        [HttpPut("ReservationRoom")]
        public async Task<IActionResult> ReservationRoom(string roomNumber, DateTime bookingEndDate, DateTime bookingStartDate)
        {
            var response = await _roomService.ReservationRoom(roomNumber, bookingEndDate, bookingStartDate);
            return Ok(response);
        }

        [HttpPut("ProlongationRoom")]
        public async Task<IActionResult> ProlongationRoom(string roomNumber, DateTime newBookingEndDate)
        {
            var response = await _roomService.ProlongationRoom(roomNumber, newBookingEndDate);
            return Ok(response);
        }

        [HttpPut("EvictionFromRoom")]
        public async Task<IActionResult> EvictionFromRoom(string roomNumber)
        {
            var response = await _roomService.EvictionFromRoom(roomNumber);
            return Ok(response);
        }


        [HttpPost("CreateRoom")]
        public async Task<IActionResult> CreateRoom(CreateGuestDTO model)
        {
            var response = await _roomService.CreateAsync(model);
            return Ok(response);
        }
    }
}
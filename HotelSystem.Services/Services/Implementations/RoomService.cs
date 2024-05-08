using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Payment;
using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;

namespace HotelSystem.Services.Services.Implementations
{
    public class RoomService : BaseService<Room>, IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository) : base(roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IBaseResponse<bool>> EvictionFromRoom(string roomNumber)
        {
            try
            {
                StringValidator.CheckIsNotNull(roomNumber);

                var room = await _roomRepository.GetRoomByNumberAsync(roomNumber);
                ObjectValidator<Room>.CheckIsNotNullObject(room);

                room.IsBooked = false;
                room.BookingEndDate = DateTime.Now;

                await _roomRepository.Update(room);
                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<bool>> ProlongationRoom(string roomNumber, DateTime newBookingEndDate)
        {
            try
            {
                StringValidator.CheckIsNotNull(roomNumber);

                var room = await _roomRepository.GetRoomByNumberAsync(roomNumber);
                ObjectValidator<Room>.CheckIsNotNullObject(room);

                room.BookingEndDate = newBookingEndDate;

                await _roomRepository.Update(room);
                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }

        public async Task<IBaseResponse<bool>> ReservationRoom(string roomNumber, DateTime bookingEndDate, DateTime bookingStartDate)
        {
            try
            {
                StringValidator.CheckIsNotNull(roomNumber);

                var room = await _roomRepository.GetRoomByNumberAsync(roomNumber);
                ObjectValidator<Room>.CheckIsNotNullObject(room);

                room.IsBooked = true;
                room.BookingStartDate = bookingStartDate;
                room.BookingEndDate = bookingEndDate;

                await _roomRepository.Update(room);
                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);
            }
        }
    }
}

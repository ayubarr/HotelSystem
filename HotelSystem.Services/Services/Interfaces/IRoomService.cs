using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Payment;
using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Room;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Services.Services.Interfaces
{
    public interface IRoomService : IBaseService<Room>
    {
        Task<IBaseResponse<bool>> ReservationRoom(string roomNumber, DateTime bookingEndDate, DateTime bookingStartDate);
        Task<IBaseResponse<bool>> EvictionFromRoom(string roomNumber);
        Task<IBaseResponse<bool>> ProlongationRoom(string roomNumber, DateTime newBookingEndDate);
        Task<IBaseResponse<bool>> DeleteRoomByNumber(string roomNumber);
    }
}

using HotelSystem.ApiModels.DTOs.EntitiesDTOs.Room;
using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Mapping;
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


                _roomRepository.GetRoomByNumberAsync(roomNumber);

                return ResponseFactory<bool>.CreateSuccessResponse(true);
            }
            catch (Exception ex)
            {
                return ResponseFactory<bool>.CreateErrorResponse(ex);

            }
        }

        public Task<IBaseResponse<bool>> ProlongationRoom(UpdateRoomDTO entitieDto)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> ReservationRoom(UpdateRoomDTO entitieDto)
        {
            throw new NotImplementedException();
        }
    }
}

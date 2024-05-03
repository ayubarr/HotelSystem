using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Services.Services.Interfaces
{
    public interface IGuestService : IBaseService<Guest>
    {
        Task<IBaseResponse<IEnumerable<Payment>>> GetAllGuestPaymentsByIdAsync(uint guestId);
    }
}

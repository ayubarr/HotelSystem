using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Entities;

namespace HotelSystem.Services.Services.Interfaces
{
    public interface IPaymentService : IBaseService<Payment>
    {
        Task<IBaseResponse<Payment>> GuestLastPaymentByGuestIdAsync(uint Id);
    }
}

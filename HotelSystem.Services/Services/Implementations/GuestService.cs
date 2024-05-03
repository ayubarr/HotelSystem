using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;

namespace HotelSystem.Services.Services.Implementations
{
    public class GuestService : BaseService<Guest>, IGuestService
    {
        private readonly IBaseRepository<Guest> _guestRepository;

        public GuestService(IBaseRepository<Guest> guestRepository) : base(guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async Task<IBaseResponse<IEnumerable<Payment>>> GetAllGuestPaymentsByIdAsync(uint guestId)
        {
            try
            {
                var entity = await _guestRepository.GetByIdAsync(guestId);
                ObjectValidator<Guest>.CheckIsNotNullObject(entity);

                var payments = entity.Payments.ToList();
                ObjectValidator<IEnumerable<Payment>>.CheckIsNotNullObject(payments);


                return ResponseFactory<IEnumerable<Payment>>.CreateSuccessResponse(payments);
            }
            catch (Exception ex)
            {
                return ResponseFactory<IEnumerable<Payment>>.CreateErrorResponse(ex);

            }
        }
    }
}

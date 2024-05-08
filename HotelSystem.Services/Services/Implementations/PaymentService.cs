using HotelSystem.ApiModels.Response.Helpers;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services.Services.Implementations
{
    public class PaymentService : BaseService<Payment>, IPaymentService
    {
        private readonly IBaseRepository<Payment> _repository;

        public PaymentService(IBaseRepository<Payment> repository) : base(repository) 
        {
            _repository = repository;
        }

        public async Task<IBaseResponse<Payment>> GuestLastPaymentByGuestIdAsync(uint Id)
        {
            try
            {
                var guestPayment = _repository.GetAll()
                        .Where(p => p.GuestId == Id)
                        .OrderByDescending(p => p.Date)
                        .LastOrDefault();


                ObjectValidator<Payment>.CheckIsNotNullObject(guestPayment);
                return ResponseFactory<Payment>.CreateSuccessResponse(guestPayment);
            }
            catch (Exception ex)
            {
                return ResponseFactory<Payment>.CreateErrorResponse(ex);

            }
        }
    }
}

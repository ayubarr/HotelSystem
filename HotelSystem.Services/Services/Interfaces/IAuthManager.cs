using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Services.Services.Interfaces
{
    public interface IAuthManager<Tmodel> 
        where Tmodel : ApplicationUser
    {
        public Task<IBaseResponse<AuthResultStruct>> Login(LoginModel model);

        public Task<IBaseResponse<uint>> Register(RegisterModel model);

	}
}

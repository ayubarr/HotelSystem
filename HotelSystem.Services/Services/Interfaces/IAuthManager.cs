using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Services.Services.Interfaces
{
    public interface IAuthManager<Tmodel> 
        where Tmodel : ApplicationUser
    {
    }
}

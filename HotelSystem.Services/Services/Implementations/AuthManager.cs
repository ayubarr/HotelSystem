using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services.Services.Implementations
{
    public class AuthManager<T> : IAuthManager<T>
        where T : ApplicationUser
    {
    }
}

using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
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
		public Task<IBaseResponse<AuthResultStruct>> Login(LoginModel model)
		{
			throw new NotImplementedException();
		}

		public Task<IBaseResponse<uint>> Register(RegisterModel model)
		{
			throw new NotImplementedException();
		}
	}
}

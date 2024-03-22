using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services.Services.Implementations
{
	public class AuthManager<T> : IAuthManager<T>, ITokenManager<T>
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

		public Task<IBaseResponse<AuthResultStruct>> UpdateToken(TokenModel model)
		{
			throw new NotImplementedException();
		}

		string ITokenManager<T>.GenerateRefreshToken()
		{
			throw new NotImplementedException();
		}

		JwtSecurityToken ITokenManager<T>.GenerateToken(List<Claim> claims)
		{
			throw new NotImplementedException();
		}

		ClaimsPrincipal ITokenManager<T>.GetClaimsPrincipalFromExpiredToken(string? token)
		{
			throw new NotImplementedException();
		}

		Task<IBaseResponse<AuthResultStruct>> ITokenManager<T>.UpdateToken(TokenModel model)
		{
			throw new NotImplementedException();
		}
	}
}

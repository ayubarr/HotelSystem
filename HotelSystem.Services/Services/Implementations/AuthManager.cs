using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Interfaces;
using HotelSystem.Validation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
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
		private readonly UserManager<Employee> _userManager;

		private readonly IConfiguration _configuration;

		public AuthManager(UserManager<Employee> userManager,
			IConfiguration configuration)
		{
			ObjectValidator<UserManager<Employee>>.CheckIsNotNullObject(userManager);
			_userManager = userManager;

			ObjectValidator<IConfiguration>.CheckIsNotNullObject(configuration);
			_configuration = configuration;
		}



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

		JwtSecurityToken ITokenManager<T>.GenerateToken(List<Claim> authClaims)
		{
			ObjectValidator<List<Claim>>.CheckIsNotNullObject(authClaims);

			var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
			bool isTokenValidityInt = int.TryParse(_configuration["JWT:TokenValidityInMinutes"], out int tokenValidityInMinutes);

			return new JwtSecurityToken(
					issuer: _configuration["JWT:ValidIssuer"],
					audience: _configuration["JWT:ValidAudience"],
					expires: DateTime.Now.AddMinutes(isTokenValidityInt ? tokenValidityInMinutes : 0),
					claims: authClaims,
					signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
					);


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

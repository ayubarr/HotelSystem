using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Interfaces;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services.Services.Interfaces
{
	/// <summary>
	/// Менеджер для работы с токенами
	/// </summary>
	public interface ITokenManager<TModel> 
		where TModel : ApplicationUser
	{
		/// <summary>
		/// Обновляет токен доступа, используя предоставленную модель токена
		/// </summary>
		/// <param name="model"> Модель токена</param>
		/// <returns> Результат обновления токена </returns>
		public Task<IBaseResponse<AuthResultStruct>> UpdateToken(TokenModel model);

		/// <summary>
		/// Создает токен доступа, используя предоставленный список утверждений пользователя
		/// </summary>
		/// <param name="claims"> список утверждений пользователя </param>
		/// <returns> Токен доступа </returns>
		protected JwtSecurityToken GenerateToken(List<Claim> claims);

		/// <summary>
		/// Генерирует токен обновления.
		/// </summary>
		/// <returns> Токен обновления </returns>
		protected string GenerateRefreshToken();

		/// <summary>
		/// Возвращает основные утверждения из истекшего JWT токена
		/// </summary>
		/// <param name="token"> токен доступа</param>
		/// <returns> Основные утверждения токена </returns>
		protected ClaimsPrincipal GetClaimsPrincipalFromExpiredToken(string? token);
	}
}

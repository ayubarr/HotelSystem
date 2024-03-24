using HotelSystem.ApiModels.Auth;
using HotelSystem.ApiModels.Response.Helpers;
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
        /// Отзывает токен обновления для пользователя с указанным именем пользователя.
        /// </summary>
        /// <param name="username">Имя пользователя, для которого нужно отозвать токен обновления.</param>
        /// <returns>Задача, представляющая асинхронную операцию и содержащая <see cref="IBaseResponse{T}"/>, где T - логическое значение, указывающее на успешность или неудачу отзыва токена.</returns>
        public Task<IBaseResponse<bool>> RevokeRefreshTokenByUsernameAsync(string username);

        /// <summary>
        /// Отзывает все токены обновления.
        /// </summary>
        /// <returns>Задача, представляющая асинхронную операцию и содержащая <see cref="IBaseResponse{T}"/>, где T - логическое значение, указывающее на успешность или неудачу отзыва всех токенов обновления.</returns>
        public Task<IBaseResponse<bool>> RevokeAllRefreshTokensAsync();
    }
}

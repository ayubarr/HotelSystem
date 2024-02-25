using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelSystem.Domain.Models.Abstractions.BaseEntities
{
    /// <summary>
    /// Пользователь приложения
    /// </summary>
    public class ApplicationUser : IdentityUser<uint>
    {
        /// <summary>
        /// Токен обновления (для авторизации)
        /// </summary>
        public string? RefreshToken { get; set; }
        /// <summary>
        /// Время истечения токена обновления
        /// </summary>
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}

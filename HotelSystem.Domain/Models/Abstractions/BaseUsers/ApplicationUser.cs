using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Domain.Models.Abstractions.BaseUsers
{
    /// <summary>
    /// Пользователь приложения
    /// </summary>
    public class ApplicationUser : IdentityUser
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

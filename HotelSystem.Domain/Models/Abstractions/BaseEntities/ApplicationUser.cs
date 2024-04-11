using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Domain.Models.Abstractions.BaseEntities
{
	/// <summary>
	/// ApplicationUser - Пользователь приложения
	/// <see cref="RefreshToken">           Токен обновления (для авторизации)      </see>
	/// <see cref="RefreshTokenExpiryTime"> Время истечения токена обновления       </see>
	/// </summary>
	public class ApplicationUser : IdentityUser<uint>
    {

        public string? RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}

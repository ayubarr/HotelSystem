using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Domain.Models.Abstractions.BaseUsers
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}

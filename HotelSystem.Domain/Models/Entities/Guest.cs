using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Гость отеля
    /// </summary>
    public class Guest : BaseEntity 
    {
        /// <summary>
        /// Имя гостя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия гостя
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// отчество гостя
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Контактная информация гостя (номер телефона, адрес электронной почты и т.д.)
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Контактная информация гостя (номер телефона, адрес электронной почты и т.д.)
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Дата начала регистрации гостя
        /// </summary>
        public DateTime RegistrationStartDate { get; set; }
        /// <summary>
        /// Дата окончания регестрации гостя
        /// </summary>
        public DateTime RegistrationEndDate { get; set; }

        public List<ServiceEntityGuest>? ServiceEntities { get; set; }
        public List<Payment>? Payments { get; set; }

    }
}

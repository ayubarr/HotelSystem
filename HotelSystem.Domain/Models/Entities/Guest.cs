using HotelSystem.Domain.Models.Abstractions.BaseEntities;

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
        /// Контактная информация гостя (номер телефона, адрес электронной почты и т.д.)
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// Дата начала регистрации гостя
        /// </summary>
        public DateTime RegistrationStartDate { get; set; }
        /// <summary>
        /// Дата окончания регестрации гостя
        /// </summary>
        public DateTime RegistrationEndDate { get; set;}

    }
}

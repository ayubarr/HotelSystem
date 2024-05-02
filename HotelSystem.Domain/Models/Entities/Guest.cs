using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// Guest - Гость отеля
	/// <see cref=" FirstName">             Имя гостя                                               </see>
	/// <see cref=" LastName">              Фамилия гостя                                           </see>
	/// <see cref=" MiddleName">            Отчество гостя                                          </see>
	/// <see cref=" Email">                 Контактная информация гостя адрес электронной почты     </see>
	/// <see cref=" PhoneNumber">           Контактная информация гостя номер телефона              </see>
	/// <see cref="RegistrationStartDate">  Дата начала регистрации гостя                           </see>
	/// <see cref="RegistrationEndDate">    Дата окончания регестрации гостя                        </see>
	/// </summary>
	public class Guest : BaseEntity 
    {
        public Guest() // Конструктор по умолчанию
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationEndDate { get; set; }

        public List<ServiceEntityGuest>? ServiceEntities { get; set; }
        public List<Payment>? Payments { get; set; }

    }
}

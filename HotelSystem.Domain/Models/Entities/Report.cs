using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Domain.Models.Entities
{
    /// <summary>
    /// Сущность отчета
    /// </summary>
    public class Report : BaseEntity
    {
        /// <summary>
        /// Название отчета
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание отчета
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создания отчета
        /// </summary>
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Дата последнего обновления отчета
        /// </summary>
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// Тело отчета (может содержать текст или ссылку на файл)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Автор отчета
        /// </summary>
        public string Author { get; set; }

        public uint? EmloyeeId { get; set; }
        public Employee? Emloyee { get; set; }
    }
}

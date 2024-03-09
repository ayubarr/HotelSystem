using HotelSystem.Domain.Models.Abstractions.BaseEntities;

namespace HotelSystem.Domain.Models.Entities
{
	/// <summary>
	/// Report - Сущность отчета
	/// <see cref="Title">			Название отчета                                         <see/>
	/// <see cref="Description">	Описание отчета                                         <see/>
	/// <see cref="CreationDate">	Дата создания отчета                                    <see/>
	/// <see cref="LastUpdateDate">	Дата последнего обновления отчета                       <see/>
	/// <see cref="Body">			Тело отчета (может содержать текст или ссылку на файл)  <see/>
	/// <see cref="Author">			Автор отчета                                            <see/>
	/// <see cref="EmloyeeId">							<see/>
	/// <see cref="Emloyee">							<see/>
	/// </summary>
	public class Report : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string Body { get; set; }

        public string Author { get; set; }

        public uint? EmloyeeId { get; set; }
        public Employee? Emloyee { get; set; }
    }
}

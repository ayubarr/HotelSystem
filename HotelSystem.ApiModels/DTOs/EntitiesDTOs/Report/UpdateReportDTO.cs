using HotelSystem.ApiModels.DTOs.BaseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Report
{
	public class UpdateReportDTO : BaseDTO
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime LastUpdateDate { get; set; }

		public string Body { get; set; }

		public string Author { get; set; }
	}
}

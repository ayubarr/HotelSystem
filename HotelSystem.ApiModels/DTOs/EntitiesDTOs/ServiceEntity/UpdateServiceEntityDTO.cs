using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.ServiceEntity
{
	public class UpdateServiceEntityDTO : BaseDTO
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public bool IsAvailable { get; set; }

		public ServiceType ServiceType { get; set; }
	}
}

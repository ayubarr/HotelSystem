﻿using HotelSystem.ApiModels.DTOs.BaseDTOs;
using HotelSystem.Domain.Models.Abstractions.LinkEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Guest
{
    public class CreateGuestDTO : BaseDTO
    {
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string MiddleName { get; set; }

		public string? Email { get; set; }

		public string? PhoneNumber { get; set; }

		public DateTime RegistrationStartDate { get; set; }

		public DateTime RegistrationEndDate { get; set; }
	}
}

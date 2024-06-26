﻿using HotelSystem.ApiModels.DTOs.BaseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.ApiModels.DTOs.EntitiesDTOs.Payment
{
	public class CreatePaymentDTO : BaseDTO
	{
        public uint? GuestId { get; set; }
        public decimal? Amount { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
	}
}

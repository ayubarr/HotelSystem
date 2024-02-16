﻿using Microsoft.AspNetCore.Identity;

namespace HotelSystem.Domain.Models.Abstractions.BaseUsers
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() : base()
        {
            Id = Guid.NewGuid().ToString();
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}

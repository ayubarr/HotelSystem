using HotelSystem.DAL.Repository.Implentations;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Services.Services.Implementations;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HotelSystem.API
{
    public static class initializer
    {
        public static IServiceCollection InitializeRepositories(this IServiceCollection services)
        {
            #region Base_Repositories 
            services.AddScoped(typeof(BaseRepository<>), typeof(IBaseRepository<>));
            services.AddScoped(typeof(UserManager<>));
            #endregion
            return services;
        }

        public static IServiceCollection InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthManager<Employee>, AuthManager<Employee>>();

            return services;

        }




    }
}

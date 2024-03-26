using HotelSystem.DAL.Repository.Implentations;
using HotelSystem.DAL.Repository.Interfaces;
using HotelSystem.DAL.SqlServer.Context;
using HotelSystem.Domain.Models.Abstractions.BaseEntities;
using HotelSystem.Domain.Models.Entities;
using HotelSystem.Domain.Models.Enums;
using HotelSystem.Services.Services.Implementations;
using HotelSystem.Services.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Text;

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


        public static IServiceCollection InitializeIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<RoleManager<IdentityRole>>();

            services.AddScoped<IAuthManager<Employee>>(provider =>
            {
                var userManager = provider.GetRequiredService<UserManager<Employee>>();
                return new AuthManager<Employee>(userManager, configuration);
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,

                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });

            services.AddIdentity<ApplicationUser, IdentityRole<uint>>()
                 .AddEntityFrameworkStores<AppDbContext>()
                 .AddDefaultTokenProviders();

            services.AddScoped<IUserStore<Employee>, UserStore<Employee, IdentityRole<uint>, AppDbContext, uint>>();
            services.AddScoped<IPasswordHasher<Employee>, PasswordHasher<Employee>>();

            return services;
        }

        public static async Task InitializeRoles(this IServiceCollection services)
        {
            var roleManager = services.BuildServiceProvider().GetRequiredService<RoleManager<IdentityRole>>();
            await SeedRoles(roleManager);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            foreach (var role in Enum.GetValues(typeof(PositionType)).Cast<PositionType>())
            {
                var roleName = role.ToString();

                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }

        public async static Task SeedAdmins(this IServiceCollection services)
        {
            var userManager = services.BuildServiceProvider().GetRequiredService<UserManager<Employee>>();
            const uint adminId = 0;
            const string adminName = "Admin";

            var user = await userManager.FindByNameAsync(adminName);
            if (user != null) return;

            var admin = new Employee()
            {
                Id = adminId,
                FirstName = "Admin",
                LastName = "Admin",
                MiddleName = "Admin",
                Email = "admin@admin.com",
                UserName = adminName,
                NormalizedUserName = "Ayub".Normalize(),
                NormalizedEmail = "admin@admin.com".Normalize(),
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "P@ssw0rd!");


            await userManager.CreateAsync(admin);
            await userManager.AddToRoleAsync(admin, PositionType.Admin.ToString());
        }


        //public static void IntialiseLogger(this ILoggingBuilder loggingBuilder, Action<DbLoggerOptions> configure)
        //{
        //    loggingBuilder.Services.AddSingleton<ILoggerProvider, DbLoggerProvider>();
        //    loggingBuilder.Services.Configure(configure);
        //}

    }
}

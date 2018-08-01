using GamesPortal.BL.DTOs;
using GamesPortal.BL.Services;
using GamesPortal.BL.Services.Interfaces;
using GamesPortal.DAL.Context;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories;
using GamesPortal.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace GamesPortal.Api.Resources.Utilities
{
    public static class ServiceLocator
    {
        public static void RegisterDependencies(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GamesPortalDBConnection"), b => b.MigrationsAssembly("GamesPortal.Api")));

            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Game>, GameRepository>();
            services.AddScoped<IRepository<Score>, ScoreRepository>();
            services.AddScoped<IBusinessLogic<UserDto>, UserService>();
            services.AddScoped<IBusinessLogic<GameDto>, GameService>();
            services.AddScoped<IBusinessLogic<ScoreDto>, ScoreService>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                        ClockSkew = TimeSpan.Zero
                    };
                });
        }
    }
}

using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicatonServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<iTokenService, TokenService>(); //Used for token service inetrface
            services.AddDbContext<DataContext>(config => config.UseSqlite("connectionString"));

            return services;
        }
    }
}
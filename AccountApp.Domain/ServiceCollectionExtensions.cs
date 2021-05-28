using AccountApp.Domain.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AccountApp.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AccountDBContext>(o => 
                o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}

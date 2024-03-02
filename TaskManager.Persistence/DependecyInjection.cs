using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Application.Abstractions;

namespace TaskManager.Persistence
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DefaultConnection"];

            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>((b) => b.UseNpgsql(connectionString));

            return services;
        }
    }
}

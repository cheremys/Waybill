using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Waybill.Application.Repositories;
using Waybill.Infrastructure.Repositories;

namespace Waybill.Infrastructure;

public static class Configurations
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsHistoryTable("_EfMigrations",
                    configuration.GetSection("Schema").Value)));
        services.AddScoped<IRideRepository, RideRepository>();
        return services;
    }
}
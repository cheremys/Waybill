using Microsoft.Extensions.DependencyInjection;
using Waybill.Application.RideArea;

namespace Waybill.Application;

public static class Configurations
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IRideService, RideService>();
        return services;
    }
}
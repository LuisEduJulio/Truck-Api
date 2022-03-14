using Microsoft.Extensions.DependencyInjection;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Repositories;

namespace Truck.IOC
{
    public static class IoCExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services
                .AddTransient<ITruckRepository, TruckRepository>();
        }
    }
}
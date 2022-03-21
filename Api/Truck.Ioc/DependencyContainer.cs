using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Truck.Application.Commands;
using Truck.Infraestructure.Factory;

namespace Truck.IOC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterIocDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services
                .AddMvc();

            services
               .AddHttpClient();

            services
                .AddControllers();

            services.AddAutoMapperConfiguration();

            services
                .AddFluentValidation(fv => fv
                    .RegisterValidatorsFromAssemblyContaining<TruckCreateCommand>());

            services
                .AddDbContext<AppDbContext>(options => options
                    .UseSqlServer(Configuration
                        .GetConnectionString("Connection")));

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyMethod().AllowAnyHeader());
            });

            services
                .RegisterRepositories();

            services
                .AddMediatRSetup();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Truck.Api", Version = "v1" });
            });

            return services;
        }
    }
}
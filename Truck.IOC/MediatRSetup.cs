using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Truck.IOC
{
    public static class MediatRSetup
    {
        public static void AddMediatRSetup(this IServiceCollection services)
        {
            var assemblies = new System.Reflection.Assembly[]
            {
                AppDomain.CurrentDomain.Load("Truck.Application")
            };

            services.AddMediatR(assemblies);
        }
    }
}
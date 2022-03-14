﻿using Microsoft.Extensions.DependencyInjection;
using System;
using Truck.Application.Mappers;

namespace Truck.IOC
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(CommandsToEntityMapperProfile));
        }
    }
}
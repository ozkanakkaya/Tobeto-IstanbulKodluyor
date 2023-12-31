﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(configuration => { configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());//typeof(GeneralMapping)
            return services;
        }
    }
}

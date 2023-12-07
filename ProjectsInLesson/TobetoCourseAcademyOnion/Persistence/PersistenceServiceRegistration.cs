﻿using Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TobetoCAOnionDb;Integrated Security=True"));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}


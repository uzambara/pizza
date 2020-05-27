﻿using Innoscripta.Pizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Innoscripta.Pizza.AppStart.ServicesConfiguration
{
    public static class DataBaseConfigure
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContextPool<PizzaDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("pizza"), builder =>
                {
                    builder.UseRelationalNulls(true);
                });
            });
        }
    }
}
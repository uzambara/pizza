using Innoscripta.Pizza.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Innoscripta.Pizza.Configuration.ServiceCollectionConfiguration
{
    public static class DataBaseConfigure
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContextPool<PizzaDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("pizza"), builder =>
                {
                    builder.UseRelationalNulls(true);
                });
            });
        }

        public static IApplicationBuilder UseDatabaseConfiguration(this IApplicationBuilder builder)
        {
            using var serviceScope = builder.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<PizzaDbContext>();
            context.Database.Migrate();

            return builder;
        }
    }
}

using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Innoscripta.Pizza.Configuration.ServiceCollectionConfiguration
{
    public static class ControllersConfiguration
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            MvcServiceCollectionExtensions.AddControllers(services)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                })
                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<Startup>());

            return services;
        }
    }
}
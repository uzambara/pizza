using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Innoscripta.Pizza.AppStart.ServicesConfiguration
{
    public static class ControllerConfiguration
    {
        public static IServiceCollection ConfigureControllers(this IServiceCollection services)
        {
            services
                .AddControllers()
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
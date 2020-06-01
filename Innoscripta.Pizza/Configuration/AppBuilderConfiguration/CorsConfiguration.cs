using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Innoscripta.Pizza.Configuration.AppBuilderConfiguration
{
    public static class CorsConfiguration
    {
        public static IApplicationBuilder UseCorsMiddleware(this IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseCors(builder =>
                {
                    var credentials = configuration.GetSection("AllowedHosts").Get<string[]>();
                    builder
                        .WithOrigins(credentials.ToArray())
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            }

            return app;
        }
    }
}
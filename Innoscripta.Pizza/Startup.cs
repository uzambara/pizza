using System;
using System.Linq;
using AutoMapper;
using Innoscripta.Pizza.Configuration.AppBuilderConfiguration;
using Innoscripta.Pizza.Configuration.ServiceCollectionConfiguration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Innoscripta.Pizza
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            ControllersConfiguration.AddControllers(services);
            services.AddDatabase(Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddAuthenticationConfiguration();
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });
            services.AddAppServices();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,  ILogger<Startup> logger)
        {
            app.UseExceptionHandlerMiddleware(env, logger);
            logger.LogDebug(string.Join(" ", Configuration.GetSection("AllowedHosts").Get<string[]>()));
            app.UseCorsMiddleware(env, Configuration);

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";
            });

            app.UseDatabaseConfiguration();
            Console.WriteLine("Service started on https://localhost:5001 http://localhost:5000!!!!");
        }
    }
}

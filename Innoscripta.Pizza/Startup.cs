using System.Linq;
using AutoMapper;
using FluentValidation.AspNetCore;
using Innoscripta.Pizza.AppStart.ServicesConfiguration;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Services.Implementations;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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
            services.ConfigureControllers();
            services.ConfigureDatabase(Configuration);
            services.AddAutoMapper(typeof(Startup));
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; });

            services.AddScoped(typeof(BaseRepository<>));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<OrderEntityFactory>();
            services.AddTransient<OrderItemFactory>();
            services.AddTransient<UserEntityFactory>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,  ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = 400;
                    context.Response.ContentType = "application/json";

                    var exceptionHandlerFeature =
                        context.Features.Get<IExceptionHandlerFeature>();

                    logger.LogError(exceptionHandlerFeature.Error, "UNHANDLED APP EXCEPTION");
                    await context.Response.WriteAsync(exceptionHandlerFeature.Error.ToString());
                });
            });

            if (env.IsDevelopment())
            {
                // подключаем CORS
                app.UseCors(builder =>
                {
                    var credentials = Configuration.GetSection("AllowedHosts").Get<string[]>();
                    builder
                        .WithOrigins(credentials.ToArray())
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            }

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
        }
    }
}
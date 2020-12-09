using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Innoscripta.Pizza.Configuration.AppBuilderConfiguration
{
    public static class ExceptionHandlerConfiguration
    {
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
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
                    Console.WriteLine(exceptionHandlerFeature.Error);
                    await context.Response.WriteAsync(exceptionHandlerFeature.Error.ToString());
                });
            });

            return app;
        }
    }
}

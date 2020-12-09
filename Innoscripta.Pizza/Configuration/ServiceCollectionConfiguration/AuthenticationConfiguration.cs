using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Innoscripta.Pizza.Configuration.ServiceCollectionConfiguration
{
    public static class AuthenticationConfiguration
    {
        public static IServiceCollection AddAuthenticationConfiguration(this IServiceCollection services)
        {
            services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //options.Cookie.SameSite = SameSiteMode.None;
                    options.LoginPath = new PathString("/login");
                });
            return services;
        }
    }
}

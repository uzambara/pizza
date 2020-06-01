using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Services.Implementations;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Innoscripta.Pizza.Configuration.ServiceCollectionConfiguration
{
    public static class AppServices
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseRepository<>));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHashService, HashService>();

            services.AddTransient<OrderEntityFactory>();
            services.AddTransient<OrderItemFactory>();
            services.AddTransient<UserEntityFactory>();
            services.AddTransient<CommentFactory>();
            services.AddTransient<UserStatisticFactory>();
            return services;
        }
    }
}
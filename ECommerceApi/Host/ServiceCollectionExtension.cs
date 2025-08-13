using Application.Interface.Repositories;
using Application.Interface.Services;
using Application.Service;
using Persistence.Repositories;

namespace Host
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ICartRepository, CartRepository>()
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IUserService, UserService>()
                .AddScoped<IProductService, ProductService>()
                .AddScoped<ICartService, CartService>();
        }
    }
}

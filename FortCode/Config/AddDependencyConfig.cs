using FortCode.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FortCode.Config
{
    public static  class AddDependencyConfig
    {
        public static IServiceCollection AddInjectionDependency(this IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserCityRepository, UserCityRepository>();
            return services;
        }
    }
}

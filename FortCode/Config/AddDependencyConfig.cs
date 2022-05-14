using FortRobotics.API.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FortRobotics.API.Config
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

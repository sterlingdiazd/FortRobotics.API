using FortRobotics.API.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FortRobotics.API.Config
{
    public static  class AddDependencyConfig
    {
        public static IServiceCollection AddInjectionDependency(this IServiceCollection services)
        {
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IUserCityRepository, UserCityRepository>();
            return services;
        }
    }
}

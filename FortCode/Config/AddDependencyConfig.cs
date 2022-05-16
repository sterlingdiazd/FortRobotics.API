using FortCode.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FortCode.Config
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

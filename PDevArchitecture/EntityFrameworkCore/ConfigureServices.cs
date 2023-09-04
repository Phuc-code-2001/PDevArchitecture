using PDevArchitecture.EntityFrameworkCore.Repositories;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRepositoryCore(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEfCoreRepository<,>), typeof(EfCoreRepository<,>));
            return services;
        }
    }
}

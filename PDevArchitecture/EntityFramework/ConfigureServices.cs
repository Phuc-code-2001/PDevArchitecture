using PDevArchitecture.EntityFramework.Repositories;
using PDevArchitecture.EntityFramework.Repositories.Interfaces;

namespace PDevArchitecture.EntityFramework
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRepositoryCore(this IServiceCollection services)
        {
            services.AddScoped(typeof(IQueryRepository<,>), typeof(QueryRepository<,>));
            services.AddScoped(typeof(ICommandRepository<,>), typeof(CommandRepository<,>));
            services.AddScoped(typeof(ICRUDRepository<,>), typeof(CRUDRepository<,>));

            return services;
        }
    }
}

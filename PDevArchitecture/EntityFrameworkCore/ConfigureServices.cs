using PDevArchitecture.EntityFrameworkCore.Repositories;
using PDevArchitecture.EntityFrameworkCore.Repositories.Interfaces;

namespace PDevArchitecture.EntityFrameworkCore
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

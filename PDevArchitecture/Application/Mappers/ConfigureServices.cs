using PDevArchitecture.Application.Mappers.Helpers;

namespace PDevArchitecture.Application.Mappers
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddHelperMapppingService(this IServiceCollection services)
        {
            services.AddScoped<EntityMapper>();
            return services;
        }
    }
}

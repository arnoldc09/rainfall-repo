using RainfallApi.Mappings;

namespace RainfallApi
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddRainfallServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(RainfallProfile));

            return services;
        }
    }
}

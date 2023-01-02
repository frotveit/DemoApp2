using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public static class Setup
    {
        public static IServiceCollection SetupServices(this IServiceCollection services)
        {
            services.AddTransient<IDeepPingService, DeepPingService>();

            return services;
        }
    }
}

using Repository;
using Service;
using Microsoft.Extensions.Configuration;

namespace Api.Setup
{
    public static class ServicesSetup
    {
        public static IServiceCollection Setup(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.SetupRepository(configuration);

            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.SetupServices();

            return services;
        }
    }
}

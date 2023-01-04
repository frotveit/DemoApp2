using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Repository.Repository;

namespace Repository
{
    public static class Setup
    {
        public static IServiceCollection SetupRepository(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddTransient<IHealthCheckRepository, HealthCheckRepository>();

            return services;
        }

        public static WebApplication SetupRepository(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DatabaseContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    try
                    {
                        var logger = services.GetRequiredService<ILogger>();
                        logger.LogError(ex, "An error occurred while seeding the database.");
                    }
                    catch
                    {
                        // .
                    }
                }
            }
            return app;
        }
    }
}
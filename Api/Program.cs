using Api.Setup;

using NLog;
using NLog.Web;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Info("Starting");

try
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.Setup(builder.Configuration);

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();

    app = app.Setup();

    app.Run();
}
catch (Exception exception)
{
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}
using Microsoft.Extensions.Logging;

namespace Service
{
    public class DeepPingService : IDeepPingService
    {
        private readonly ILogger<DeepPingService> _logger;
        public DeepPingService(ILogger<DeepPingService> logger)
        {
            _logger = logger;
        }

        public string DeepPing()
        {
            _logger?.LogInformation("DeepPing");
            return "Pong";
        }
    }
}
using Microsoft.Extensions.Logging;
using Repository.Repository;

namespace Service
{
    public class DeepPingService : IDeepPingService
    {
        private readonly IHealthCheckRepository _healthCheckRepository;
        private readonly ILogger<DeepPingService> _logger;

        public DeepPingService(IHealthCheckRepository healthCheckRepository, ILogger<DeepPingService> logger)
        {
            _healthCheckRepository = healthCheckRepository;
            _logger = logger;
        }

        public async Task<string> DeepPing()
        {
            if (!await _healthCheckRepository.Ping())
            {
                _logger?.LogError("DeepPing: Database ping feilet");
                return "Database ping feilet";
            }

            _logger?.LogInformation("DeepPing");
            return "Pong";
        }
    }
}
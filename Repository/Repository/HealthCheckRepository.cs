using Microsoft.EntityFrameworkCore;

namespace Repository.Repository
{
    public class HealthCheckRepository : IHealthCheckRepository
    {
        public readonly DatabaseContext _context;

        public HealthCheckRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<bool> Ping()
        {
            return await _context.HealthCheck.AnyAsync();
        }
    }
}

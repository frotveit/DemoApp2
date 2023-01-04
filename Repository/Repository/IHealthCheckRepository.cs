namespace Repository.Repository
{
    public interface IHealthCheckRepository
    {
        Task<bool> Ping();
    }
}

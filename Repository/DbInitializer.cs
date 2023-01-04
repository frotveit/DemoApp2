using Repository.Model;

namespace Repository
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (!context.HealthCheck.Any())
            {
                context.HealthCheck.Add(new HelthCheckPollEntity());
            }

            context.SaveChanges();
        }
    }
}

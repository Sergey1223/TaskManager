using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaskManager.Persistence
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=task_manager_db;Username=system;Password=system",
                (o) => o.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds)
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}

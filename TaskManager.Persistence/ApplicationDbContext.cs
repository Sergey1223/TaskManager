using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Abstractions;
using TaskManager.Domain.Entities;
using TaskManager.Persistence.Configurations;

namespace TaskManager.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Domain.Entities.Task> Tasks { get; set; }

        public DbSet<TaskList> TaskLists { get; set; }

        public DbSet<TaskHistoryItem> TaskHistories { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new TaskListConfiguration());
            modelBuilder.ApplyConfiguration(new TaskHistoryItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

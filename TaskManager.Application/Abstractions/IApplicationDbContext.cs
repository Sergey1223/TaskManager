using Microsoft.EntityFrameworkCore;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.Task> Tasks { get; set; }

        DbSet<TaskList> TaskLists { get; set; }

        DbSet<TaskHistoryItem> TaskHistories { get; set; }

        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

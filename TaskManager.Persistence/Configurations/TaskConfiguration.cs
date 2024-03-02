using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Persistence.Configurations
{
    internal class TaskConfiguration : IEntityTypeConfiguration<Domain.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Task> builder)
        {
            builder
                .HasKey((t) => t.Id);

            builder
                .HasIndex((t) => t.Id)
                .IsUnique();

            builder
                .Property((t) => t.Name)
                    .IsRequired()
                    .HasMaxLength(256);

            builder
                .Property((t) => t.Description)
                    .HasMaxLength(512);

            builder
                .Property((t) => t.CreationDate)
                    .IsRequired();

            builder
                .Property((t) => t.TaskListId)
                    .IsRequired();

            builder
                .HasMany((t) => t.TaskHistory)
                .WithOne((i) => i.Task)
                .HasForeignKey((i) => i.TaskId);
        }
    }
}

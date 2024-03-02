using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Persistence.Configurations
{
    internal class TaskListConfiguration : IEntityTypeConfiguration<Domain.Entities.TaskList>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.TaskList> builder)
        {
            builder.HasKey((tl) => tl.Id);

            builder
                .HasIndex((tl) => tl.Id)
                .IsUnique();

            builder
                .Property((tl) => tl.Name)
                    .IsRequired()
                    .HasMaxLength(256);

            builder
                .Property((tl) => tl.Description)
                    .HasMaxLength(512);

            builder
                .HasMany((tl) => tl.Tasks)
                .WithOne((t) => t.TaskList)
                .HasForeignKey((t) => t.TaskListId);
        }
    }
}

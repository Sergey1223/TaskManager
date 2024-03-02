using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Persistence.Configurations
{
    internal class TaskHistoryItemConfiguration : IEntityTypeConfiguration<Domain.Entities.TaskHistoryItem>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.TaskHistoryItem> builder)
        {
            builder.HasKey((i) => i.Id);

            builder
                .HasIndex((i) => i.Id)
                .IsUnique();

            builder
                .Property((i) => i.ChangeDate)
                    .IsRequired();

            builder
                .Property((i) => i.TaskStatus)
                    .IsRequired();

            builder
                .Property((i) => i.TaskId)
                    .IsRequired();
        }
    }
}

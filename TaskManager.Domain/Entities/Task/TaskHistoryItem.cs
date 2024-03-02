namespace TaskManager.Domain.Entities
{
    public class TaskHistoryItem : BaseEntity
    {
        public DateTime ChangeDate { get; set; }

        public TaskStatus TaskStatus { get; set; }

        public string Comment { get; set; } = default!;

        public Guid TaskId { get; set; }

        public Task Task { get; set; } = default!;
    }
}

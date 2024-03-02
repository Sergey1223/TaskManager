namespace TaskManager.Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public DateTime CreationDate { get; set; }

        public List<TaskHistoryItem> TaskHistory { get; set; } = new List<TaskHistoryItem>();

        public Guid TaskListId { get; set; }

        public TaskList TaskList { get; set; } = default!;
    }
}

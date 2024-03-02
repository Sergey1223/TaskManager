namespace TaskManager.Domain.Entities
{
    public class TaskList : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}

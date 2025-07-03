namespace PlanWise_Client.Models
{

    public class TaskItem
    {
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }

    public class EventsViewModel
    {
        public string EventName { get; set; } = string.Empty;
        public int Step { get; set; }

        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}

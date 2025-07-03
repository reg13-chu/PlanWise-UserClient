namespace PlanWise_UserClient.Models
{
    public class Messages
    {
        public string Content { get; set; } = string.Empty;
        public bool IsSender { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

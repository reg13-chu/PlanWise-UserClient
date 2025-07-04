namespace PlanWise_UserClient.Models
{
    public class BookingViewModel
    {
        public string EventType { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;
        public string ClientEmail { get; set; } = string.Empty;
        public string ClientPhone { get; set; } = string.Empty;

        public DateTime EventDate { get; set; }
        public string EventTime { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int NumberOfGuests { get; set; }

        public decimal EstimatedBudget { get; set; }
        public string Theme { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}

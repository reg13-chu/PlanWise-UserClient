namespace PlanWise_UserClient.Models
{
    public class EstimatorViewModel
    {
        public string EventType { get; set; } = string.Empty;
        public decimal TotalBudget { get; set; }
        public int NumberOfGuests { get; set; }
        public Dictionary<string, decimal> CategoryBreakdown { get; set; } = new();
    }
}

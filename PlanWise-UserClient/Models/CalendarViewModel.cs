namespace PlanWise_UserClient.Models
{
    public class CalendarViewModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public List<DateTime> BookedDates { get; set; } = new();
    }

}

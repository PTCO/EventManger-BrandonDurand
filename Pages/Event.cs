namespace Events
{
    public class EventDetails
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = null!;
        public DateTime? EventDate { get; set; }
        public string EventLocation { get; set; } = null!;
        public bool IsRegistered { get; set; } = false;
    }
}
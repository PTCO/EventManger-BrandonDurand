namespace Events
{
    public class EventServices
    {
        public List<EventDetails> events = new List<EventDetails>
        {
            new EventDetails { EventId = 1, EventName = "Tech Conference", EventDate = new DateTime(2023, 10, 15), EventLocation = "New York", IsRegistered = false },
            new EventDetails { EventId = 2, EventName = "Music Festival", EventDate = new DateTime(2023, 11, 20), EventLocation = "Los Angeles", IsRegistered = false },
            new EventDetails { EventId = 3, EventName = "Art Exhibition", EventDate = new DateTime(2023, 12, 5), EventLocation = "San Francisco", IsRegistered = false }
        };


        public static EventDetails getEvent(int eventId)
        {
            var events = new EventServices().events;
            var result = events.FirstOrDefault(e => e.EventId == eventId);
            if (result == null)
            {
                throw new Exception($"Event with ID {eventId} not found.");
            }
            return result;
        }

        public static List<EventDetails> getEvents()
        {
            return new EventServices().events;
        }

        public void UpdateStatus(int eventid)
        {
            events.GetType().GetProperty("IsRegistered")?.SetValue(events.FirstOrDefault(e => e.EventId == eventid), true);
        }
    }
}
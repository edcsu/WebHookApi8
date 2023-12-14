namespace WebHookApi.Domain.Events
{
    public class DomainEvent
    {
        public Guid ID { get; set; }

        public Guid? ActorID { get; set; }

        public DateTime TimeStamp { get; set; }

        public EventType EventType { get; set; }
    }
}

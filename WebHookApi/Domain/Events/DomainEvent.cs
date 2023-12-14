namespace WebHookApi.Domain.Events
{
    public class DomainEvent
    {
        public Guid Id { get; set; }

        public Guid? ActorId { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public EventType EventType { get; set; }
    }
}

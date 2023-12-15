namespace WebHookApi.Domain.Events
{
    public class WebHookRemoved : DomainEvent
    {

        public WebHookRemoved()
        {

        }

        public Guid WebHookId { get; set; }

        // Add any custom props hire...
    }
}

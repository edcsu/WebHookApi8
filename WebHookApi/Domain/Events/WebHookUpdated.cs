namespace WebHookApi.Domain.Events
{
    public class WebHookUpdated : DomainEvent
    {

        public WebHookUpdated()
        {

        }

        public Guid WebHookId { get; set; }

        // Add any custom props hire...
    }
}

namespace WebHookApi.Domain.Events
{
    /// <summary>
    /// WebHookCreated
    /// </summary>
    public class WebHookCreated : DomainEvent
    {

        public Guid WebHookId { get; set; }

        // Add any custom props here...
    }

}

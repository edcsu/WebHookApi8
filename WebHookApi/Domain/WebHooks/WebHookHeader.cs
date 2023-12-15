using WebHookApi.Domain.Models;

namespace WebHookApi.Domain.WebHooks
{
    public class WebHookHeader
    {
        /// <summary>
        /// Hook header ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Linked Webhook Id
        /// </summary>
        public Guid WebHookId { get; set; }

        /// <summary>
        /// Linked Webhook
        /// </summary>
        public WebHook WebHook { get; set; } = new WebHook();

        /// <summary>
        /// Header Name
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Header content
        /// </summary>
        public string Value { get; set; } = default!;

        /// <summary>
        /// Header created time
        /// </summary>
        public DateTime CreatedTimestamp { get; set; }
    }
}

using WebHookApi.Domain.WebHooks;
using static WebHookApi.Domain.WebHooks.WebHookEvents;

namespace WebHookApi.Domain.Models
{
    public class WebHook
    {
        public WebHook()
        {
            Headers = [];
            HookEvents = [];
            Records = new List<WebHookRecord>();
        }

        /// <summary>
        /// Hook DB Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>

        /// <summary>
        /// Webhook endpoint
        /// </summary>
        public string WebHookUrl { get; set; } = default!;

        /// <summary>
        /// Webhook secret
        /// </summary>
        public string? Secret { get; set; }

        /// <summary>
        /// Content Type
        /// </summary>
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// Is active / NotActiv
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Hook Events context
        /// </summary>
        public HookEventType[] HookEvents { get; set; }

        /// <summary>
        /// Additional HTTP headers. Will be sent with hook.
        /// </summary>
        virtual public HashSet<WebHookHeader> Headers { get; set; }

        /// <summary>
        /// Hook call records history
        /// </summary>
        virtual public ICollection<WebHookRecord> Records { get; set; }

        /// <summary>
        /// Timestamp of last hook trigger
        /// </summary>
        /// <value></value>
        public DateTimeOffset? LastTrigger { get; set; }
    }
}

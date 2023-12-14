using WebHookApi.Domain.Hooks;
using static WebHookApi.Domain.Hooks.WebHookEvents;

namespace WebHookApi.Domain.Core.Models
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
        public Guid ID { get; set; }

        /// <summary>

        /// <summary>
        /// Webhook endpoint
        /// </summary>
        public string WebHookUrl { get; set; }

        /// <summary>
        /// Webhook secret
        /// </summary>
        public string? Secret { get; set; }

        /// <summary>
        /// Content Type
        /// </summary>
        public string ContentType { get; set; }

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

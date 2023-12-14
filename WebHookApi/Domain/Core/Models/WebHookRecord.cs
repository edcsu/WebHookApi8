using static WebHookApi.Domain.Hooks.WebHookEvents;

namespace WebHookApi.Domain.Core.Models
{
    public class WebHookRecord
    {
        /// <summary>
        /// Hook record DB Id
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Linked Webhook Id
        /// </summary>
        public Guid WebHookID { get; set; }

        /// <summary>
        /// Linked Webhook
        /// </summary>
        public WebHook WebHook { get; set; } = default!;

        /// <summary>
        /// WebHookType
        /// </summary>
        public HookEventType HookType { get; set; }

        /// <summary>
        /// Hook result enum
        /// </summary>
        public RecordResult Result { get; set; }

        /// <summary>
        /// Response
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Response json
        /// </summary>
        public string ResponseBody { get; set; } = default!;

        /// <summary>
        /// Request json
        /// </summary>
        public string RequestBody { get; set; } = default!;

        /// <summary>
        /// Request Headers json
        /// </summary>
        public string RequestHeaders { get; set; } = default!;

        /// <summary>
        /// Exception
        /// </summary>
        public string Exception { get; set; } = default!;

        /// <summary>
        /// Hook Call Timestamp
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }
    }


    public enum RecordResult
    {
        undefined = 0,
        ok,
        parameter_error,
        http_error,
        dataQueryError
    }
}

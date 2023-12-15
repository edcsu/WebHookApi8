namespace WebHookApi.Domain.Hooks
{
    // Actions of HookEventType
    public enum HookResourceAction
    {
        undefined,
        hook_created,
        hook_removed,
        hook_updated,
        // etc...
    }

    // Actions of ProjectEventType
    public enum ProjectAction
    {
        undefined,
        project_created,
        project_renamed,
        project_archived,
        //etc...
    }

    public enum HookGroup1Action
    {
        undefined,
        something_happened,
    }

    public enum HookGroup2Action
    {
        undefined,
        something_else_happened
    }
}

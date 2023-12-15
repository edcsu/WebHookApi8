using Microsoft.EntityFrameworkCore;
using static WebHookApi.Domain.WebHooks.WebHookEvents;
using WebHookApi.Domain.Events;
using WebHookApi.Domain.Models;

namespace WebHookApi.Persistence
{
    public class ApiDbContext : DbContext
    {
        public DbSet<WebHook> WebHooks { get; set; }

        public DbSet<WebHookRecord> WebHooksHistory { get; set; }

        public DbSet<DomainEvent> Events { get; set; }

        public ApiDbContext(
            DbContextOptions<ApiDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);

            modelBuilder.Entity<WebHookCreated>().ToTable("WebHookCreatedEvent");

            modelBuilder.Entity<WebHookRemoved>().ToTable("WebHookRemovedEvent");

            modelBuilder.Entity<WebHookUpdated>().ToTable("WebHookUpdatedEvent");

            modelBuilder.Entity<WebHook>().HasData(
                new WebHook()
                {
                    Id = new Guid("13d97a50-02d7-48cb-b215-fc9c5d9cb638"),
                    WebHookUrl = "https://localhost:5015/hookloopback",
                    IsActive = true,
                    ContentType = "application/json",
                    HookEvents = [HookEventType.hook]
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}

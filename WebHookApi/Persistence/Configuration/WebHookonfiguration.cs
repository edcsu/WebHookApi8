using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebHookApi.Domain.Models;

namespace WebHookApi.Persistence.Configuration
{
    public class WebHookonfiguration : IEntityTypeConfiguration<WebHook>
    {
        public void Configure(EntityTypeBuilder<WebHook> builder)
        {

            builder.HasKey(e => e.Id);
            
            builder.HasIndex(e => e.Id);
            
            builder.HasMany(e => e.Headers)
            .WithOne(e => e.WebHook)
            .HasForeignKey(e => e.WebHookId);

            builder.HasMany(e => e.Records)
            .WithOne(e => e.WebHook)
            .HasForeignKey(e => e.WebHookId);
        }
    }
}

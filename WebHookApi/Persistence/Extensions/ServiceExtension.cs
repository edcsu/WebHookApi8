﻿using Microsoft.EntityFrameworkCore;

namespace WebHookApi.Persistence.Extensions
{
    public static partial class ServiceExtension
    {
        public static IServiceCollection AddApiDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration configuration, string environment)
        {

            serviceCollection.AddPooledDbContextFactory<ApiDbContext>(
                (s, o) => o
                    .UseNpgsql(configuration.GetConnectionString("ApiDbContext"), option => {
                        option.EnableRetryOnFailure();

                        if (string.Equals(environment, "development", StringComparison.OrdinalIgnoreCase))
                        {
                            o.EnableDetailedErrors();
                            o.EnableSensitiveDataLogging();
                        }

                    }).UseLoggerFactory(s.GetRequiredService<ILoggerFactory>()));

            return serviceCollection;
        }
    }
}

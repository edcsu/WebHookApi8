
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebHookApi.Persistence;
using WebHookApi.Persistence.Extensions;

namespace WebHookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "";

            try
            {
                var builder = WebApplication.CreateBuilder(args);
                var configuration = builder.Configuration;

                // Add services to the container.

                builder.Services.AddControllers();
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();

                builder.Services.AddDbContext<ApiDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

                //builder.Services.AddApiDbContext(configuration, environment);

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.UseFileServer();

                ServiceExtension.Initialize(app);

                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {
                var type = ex.GetType().Name;
                if (type.Equals("StopTheHostException", StringComparison.Ordinal))
                {
                    throw;
                }

                //Log.Fatal(ex, "Unhandled exception");
            }
            finally
            {
                //Log.Information("Shut down complete");
                //Log.CloseAndFlush();
            }
        }
    }
}

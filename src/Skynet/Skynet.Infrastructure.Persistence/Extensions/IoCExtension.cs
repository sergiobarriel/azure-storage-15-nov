using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Skynet.Infrastructure.Persistence.Extensions
{
    public static class IoCExtension
    {
        public static void RegisterDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration["Persistence:ConnectionString"];

            services.AddDbContext<Context>(builder => builder.UseSqlServer(connection, sqlBuilder =>
                {
                    sqlBuilder.MigrationsHistoryTable("MigrationsHistory", "EF");
                }),
                ServiceLifetime.Transient);
        }
    }
}

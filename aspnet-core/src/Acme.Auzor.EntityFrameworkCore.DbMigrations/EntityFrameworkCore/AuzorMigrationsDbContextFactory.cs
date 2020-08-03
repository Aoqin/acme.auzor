using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.Auzor.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AuzorMigrationsDbContextFactory : IDesignTimeDbContextFactory<AuzorMigrationsDbContext>
    {
        public AuzorMigrationsDbContext CreateDbContext(string[] args)
        {
            AuzorEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AuzorMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AuzorMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

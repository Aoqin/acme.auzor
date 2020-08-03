using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Auzor.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Auzor.EntityFrameworkCore
{
    public class EntityFrameworkCoreAuzorDbSchemaMigrator
        : IAuzorDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAuzorDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AuzorMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AuzorMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
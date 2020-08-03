using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.Auzor.EntityFrameworkCore
{
    [DependsOn(
        typeof(AuzorEntityFrameworkCoreModule)
        )]
    public class AuzorEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AuzorMigrationsDbContext>();
        }
    }
}

using Acme.Auzor.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.Auzor.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AuzorEntityFrameworkCoreDbMigrationsModule),
        typeof(AuzorApplicationContractsModule)
        )]
    public class AuzorDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

using Volo.Abp.Modularity;

namespace Acme.Auzor
{
    [DependsOn(
        typeof(AuzorApplicationModule),
        typeof(AuzorDomainTestModule)
        )]
    public class AuzorApplicationTestModule : AbpModule
    {

    }
}
using Acme.Auzor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Auzor
{
    [DependsOn(
        typeof(AuzorEntityFrameworkCoreTestModule)
        )]
    public class AuzorDomainTestModule : AbpModule
    {

    }
}
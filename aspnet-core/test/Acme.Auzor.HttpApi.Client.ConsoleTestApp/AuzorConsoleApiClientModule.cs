using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.Auzor.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AuzorHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AuzorConsoleApiClientModule : AbpModule
    {
        
    }
}

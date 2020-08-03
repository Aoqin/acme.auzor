using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Auzor.Data
{
    /* This is used if database provider does't define
     * IAuzorDbSchemaMigrator implementation.
     */
    public class NullAuzorDbSchemaMigrator : IAuzorDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
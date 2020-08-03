using System.Threading.Tasks;

namespace Acme.Auzor.Data
{
    public interface IAuzorDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

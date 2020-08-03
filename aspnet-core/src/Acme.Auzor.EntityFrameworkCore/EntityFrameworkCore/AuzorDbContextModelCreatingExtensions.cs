using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.Auzor.EntityFrameworkCore
{
    public static class AuzorDbContextModelCreatingExtensions
    {
        public static void ConfigureAuzor(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AuzorConsts.DbTablePrefix + "YourEntities", AuzorConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
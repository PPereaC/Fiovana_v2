using Fiovana_v2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Fiovana_v2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Fiovana_v2EntityFrameworkCoreModule),
    typeof(Fiovana_v2ApplicationContractsModule)
)]
public class Fiovana_v2DbMigratorModule : AbpModule
{
}

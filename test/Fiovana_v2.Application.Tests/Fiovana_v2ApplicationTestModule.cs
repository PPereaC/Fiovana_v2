using Volo.Abp.Modularity;

namespace Fiovana_v2;

[DependsOn(
    typeof(Fiovana_v2ApplicationModule),
    typeof(Fiovana_v2DomainTestModule)
)]
public class Fiovana_v2ApplicationTestModule : AbpModule
{

}

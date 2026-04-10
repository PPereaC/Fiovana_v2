using Volo.Abp.Modularity;

namespace Fiovana_v2;

[DependsOn(
    typeof(Fiovana_v2DomainModule),
    typeof(Fiovana_v2TestBaseModule)
)]
public class Fiovana_v2DomainTestModule : AbpModule
{

}

using Volo.Abp.Modularity;

namespace Fiovana_v2;

/* Inherit from this class for your domain layer tests. */
public abstract class Fiovana_v2DomainTestBase<TStartupModule> : Fiovana_v2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

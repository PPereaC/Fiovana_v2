using Fiovana_v2.Samples;
using Xunit;

namespace Fiovana_v2.EntityFrameworkCore.Applications;

[Collection(Fiovana_v2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Fiovana_v2EntityFrameworkCoreTestModule>
{

}

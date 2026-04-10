using Fiovana_v2.Samples;
using Xunit;

namespace Fiovana_v2.EntityFrameworkCore.Domains;

[Collection(Fiovana_v2TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Fiovana_v2EntityFrameworkCoreTestModule>
{

}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Fiovana_v2.Data;

/* This is used if database provider does't define
 * IFiovana_v2DbSchemaMigrator implementation.
 */
public class NullFiovana_v2DbSchemaMigrator : IFiovana_v2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

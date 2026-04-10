using System.Threading.Tasks;

namespace Fiovana_v2.Data;

public interface IFiovana_v2DbSchemaMigrator
{
    Task MigrateAsync();
}

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fiovana_v2.Data;
using Volo.Abp.DependencyInjection;

namespace Fiovana_v2.EntityFrameworkCore;

public class EntityFrameworkCoreFiovana_v2DbSchemaMigrator
    : IFiovana_v2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFiovana_v2DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Fiovana_v2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Fiovana_v2DbContext>()
            .Database
            .MigrateAsync();
    }
}

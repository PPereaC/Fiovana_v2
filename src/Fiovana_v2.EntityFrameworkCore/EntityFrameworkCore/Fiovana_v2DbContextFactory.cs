using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fiovana_v2.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Fiovana_v2DbContextFactory : IDesignTimeDbContextFactory<Fiovana_v2DbContext>
{
    public Fiovana_v2DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        Fiovana_v2EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<Fiovana_v2DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new Fiovana_v2DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Fiovana_v2.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}

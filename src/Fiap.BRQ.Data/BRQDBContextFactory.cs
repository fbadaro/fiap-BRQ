using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Fiap.BRQ.Data;

public class BRQDBContextFactory : IDesignTimeDbContextFactory<BRQDBContext>
{
    public BRQDBContext CreateDbContext(string[] args)
    {
        try
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(Directory.GetCurrentDirectory() + "/../Fiap.BRQ.Api/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BRQDBContext>();
            builder.UseSqlServer(configuration["SqlServer:ConnectionString"], opt =>
                opt.MigrationsHistoryTable("MigrationBRQContext"));

            return new BRQDBContext(builder.Options);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using IMSBackend.Persistence.Context;
using IMSBackend.Persistence.Extensions;

namespace IMSBackend.Persistence.Factory;

public class IMSEcommerceContextFactory : IDesignTimeDbContextFactory<IMSEcommerceContext>
{
    public IMSEcommerceContext CreateDbContext(string[] args)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddBasePath().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

        var optionsBuilder = new DbContextOptionsBuilder<IMSEcommerceContext>();
        var connectionString = config.GetConnectionString(nameof(IMSEcommerceContext));
         optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("IMSBackend.Persistence"));
        //optionsBuilder.UseNpgsql(connectionString, b => b.MigrationsAssembly("IMSBackend.Persistence"));
        return new IMSEcommerceContext(optionsBuilder.Options);
    }
}

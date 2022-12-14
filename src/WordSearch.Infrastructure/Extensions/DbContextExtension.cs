using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prism.Ioc;
using Xamarin.Essentials;

namespace WordSearch.Infrastructure.Extensions
{
    public static class DbContextExtension
    {
        public static void AddSqliteContext<TDbContext>(this IContainerRegistry containerRegistry,
            IConfiguration configuration) where TDbContext : DbContext
        {
            var currentAssemblyName = typeof(TDbContext).Assembly.GetName().Name;
            var dbConnectionString = Path.Combine(FileSystem.AppDataDirectory,
                configuration.GetConnectionString(EnvironmentVariable.DefaultConnection));

            containerRegistry.RegisterServices(services =>
                services.AddDbContext<TDbContext>(options =>
                {
                    SQLitePCL.Batteries_V2.Init();
                    options.UseSqlite(dbConnectionString, sqliteOptions =>
                        sqliteOptions.MigrationsAssembly(currentAssemblyName));
                }));
        }
    }
}

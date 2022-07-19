namespace WordSearch.Bootstrapper.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;

    using Prism;
    using Prism.Ioc;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Data.Contexts.ApplicationDb;

    public static class DatabaseContextExtension
    {
        public static void RegisterSqliteDbContext(
            this IContainerRegistry containerRegistry,
            IDatabasableBase database)
        {
            var dbConnectionString = database.DbConnectionString;

            containerRegistry.RegisterServices(
                service => service.AddDbContext<ApplicationDbContext>(
                    options => options.UseSqlite(dbConnectionString)));

            PrismApplicationBase.Current.Container
                .Resolve<ApplicationDbContext>()
                    .Database.EnsureCreated();
        }
    }
}

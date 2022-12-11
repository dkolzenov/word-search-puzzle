namespace WordSearch.Bootstrapper.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using Prism;
    using Prism.Ioc;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Data.Contexts.ApplicationDb;

    public static class DbContextExtension
    {
        public static void RegisterSqliteDbContext(
            this IContainerRegistry containerRegistry,
            IWordSearchDatabase database)
        {
            string dbConnectionString = database.DbConnectionString;

            containerRegistry.RegisterServices(
                service => service.AddDbContext<ApplicationDbContext>(
                    options => options.UseSqlite(dbConnectionString)));

            PrismApplicationBase.Current.Container
                .Resolve<ApplicationDbContext>()
                    .Database.EnsureCreated();
        }
    }
}

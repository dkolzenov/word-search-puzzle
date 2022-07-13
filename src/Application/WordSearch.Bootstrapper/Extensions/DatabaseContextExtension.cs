namespace WordSearch.Bootstrapper.Extensions
{
    using System;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;

    using Prism;
    using Prism.Ioc;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Data.Contexts.ApplicationDb;

    public static class DatabaseContextExtension
    {
        private const string ConnectionStringName = "DefaultConnection";

        public static void RegisterSqliteDbContext(
            this IContainerRegistry containerRegistry,
            IConfiguration configuration)
        {
            var connectionString = configuration
                .GetConnectionString(ConnectionStringName);

            connectionString = InsertPlatformSpecificPath(connectionString);

            containerRegistry.RegisterServices(
                service => service.AddDbContext<ApplicationDbContext>(
                    options => options.UseSqlite(connectionString)));

            PrismApplicationBase.Current.Container
                .Resolve<ApplicationDbContext>()
                    .Database.EnsureCreated();
        }

        private static string InsertPlatformSpecificPath(string connectionString)
        {
            var dbResource = PrismApplicationBase.Current.Container
                .Resolve<IWordSearchDbResource>();

            var index = connectionString.IndexOf(dbResource.RelativePath);

            var platformSpecificPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData) + "/";

            var convertedString = connectionString.Insert(
                index, platformSpecificPath);

            return convertedString;
        }
    }
}

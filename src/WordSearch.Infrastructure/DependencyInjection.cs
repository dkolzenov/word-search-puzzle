using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prism.Ioc;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Infrastructure.Extensions;
using WordSearch.Infrastructure.Persistence;

namespace WordSearch.Infrastructure
{
    public static class DependencyInjection
    {
        public static IContainerRegistry AddInfrastructure(this IContainerRegistry containerRegistry,
            IConfiguration configuration)
        {
            InitializeDb(containerRegistry, configuration);

            return containerRegistry;
        }

        private static void InitializeDb(this IContainerRegistry containerRegistry, IConfiguration configuration)
        {
            containerRegistry.AddSqliteContext<ApplicationDbContext>(configuration);
            containerRegistry.AddServicesRegistration();

            containerRegistry.RegisterServices(services =>
                services.BuildServiceProvider()
                    .GetService<IApplicationDbContext>()!
                    .Database.Migrate());
        }
    }
}

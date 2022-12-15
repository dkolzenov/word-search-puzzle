using Microsoft.Extensions.Configuration;
using Prism.Ioc;
using WordSearch.Infrastructure.Extensions;
using WordSearch.Infrastructure.Persistence;

namespace WordSearch.Infrastructure
{
    public static class DependencyInjection
    {
        public static IContainerRegistry AddInfrastructure(this IContainerRegistry containerRegistry, IConfiguration configuration)
        {
            containerRegistry.AddSqliteContext<ApplicationDbContext>(configuration);
            containerRegistry.AddServicesRegistration();
            
            return containerRegistry;
        }
    }
}

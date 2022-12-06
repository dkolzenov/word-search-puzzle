using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Prism.Ioc;

namespace WordSearch.Application
{
    public static class DependencyInjection
    {
        public static IContainerRegistry AddApplication(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterServices(services => 
                services.AddAutoMapper(Assembly.GetExecutingAssembly()));
            
            containerRegistry.RegisterServices(services =>
                services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

            return containerRegistry;
        }
    }
}

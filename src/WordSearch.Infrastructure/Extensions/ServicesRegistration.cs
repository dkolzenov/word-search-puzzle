using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Prism.Ioc;
using WordSearch.Application.Common.Interfaces;

namespace WordSearch.Infrastructure.Extensions
{
    public static class ServicesRegistration
    {
        public static IContainerRegistry AddServicesRegistration(this IContainerRegistry containerRegistry)
        {
            var assemblyTypes = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .ToList();

            var singletonInterfaceTypes = GetOrderedInterfaces<ISingletonService>(assemblyTypes);
            var singletonImplTypes = GetOrderedImplementations<ISingletonService>(assemblyTypes);

            var scopedInterfaceTypes = GetOrderedInterfaces<IScopedService>(assemblyTypes);
            var scopedImplTypes = GetOrderedImplementations<IScopedService>(assemblyTypes);

            var transientInterfaceTypes = GetOrderedInterfaces<ITransientService>(assemblyTypes);
            var transientImplTypes = GetOrderedImplementations<ITransientService>(assemblyTypes);

            for (var i = 0; i < singletonInterfaceTypes.Count; i++)
            {
                containerRegistry.RegisterServices(services =>
                    services.AddSingleton(singletonInterfaceTypes[i], singletonImplTypes[i]));
            }

            for (var i = 0; i < scopedInterfaceTypes.Count; i++)
            {
                containerRegistry.RegisterServices(services =>
                    services.AddScoped(scopedInterfaceTypes[i], scopedImplTypes[i]));
            }

            for (var i = 0; i < transientInterfaceTypes.Count; i++)
            {
                containerRegistry.RegisterServices(services =>
                    services.AddTransient(transientInterfaceTypes[i], transientImplTypes[i]));
            }

            return containerRegistry;
        }

        private static IList<Type> GetOrderedImplementations<T>(IEnumerable<Type> assemblyTypes)
        {
            return assemblyTypes.Where(type =>
                    type.IsClass && typeof(T).IsAssignableFrom(type))
                .OrderBy(x => x.Name)
                .ToList();
        }

        private static IList<Type> GetOrderedInterfaces<T>(IEnumerable<Type> assemblyTypes)
        {
            return assemblyTypes.Where(type =>
                    type.IsInterface && typeof(T).IsAssignableFrom(type) && type != typeof(T))
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}

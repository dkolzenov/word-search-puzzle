using System;
using System.Linq;
using System.Collections.Generic;
using Prism.Ioc;
using WordSearch.Application.Common.Interfaces.Services;

namespace WordSearch.Application.Extensions
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

            var scopedInterfaceTypes = GetOrderedInterfaces<ISingletonService>(assemblyTypes);
            var scopedImplTypes = GetOrderedImplementations<ISingletonService>(assemblyTypes);

            var transientInterfaceTypes = GetOrderedInterfaces<ISingletonService>(assemblyTypes);
            var transientImplTypes = GetOrderedImplementations<ISingletonService>(assemblyTypes);

            for (var i = 0; i < singletonInterfaceTypes.Count; i++)
            {
                containerRegistry.RegisterSingleton(singletonInterfaceTypes[i], singletonImplTypes[i]);
            }

            for (var i = 0; i < scopedInterfaceTypes.Count; i++)
            {
                containerRegistry.RegisterScoped(scopedInterfaceTypes[i], scopedImplTypes[i]);
            }

            for (var i = 0; i < transientInterfaceTypes.Count; i++)
            {
                containerRegistry.Register(transientInterfaceTypes[i], transientImplTypes[i]);
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
                    type.IsInterface && typeof(T).IsAssignableFrom(type) && type != typeof(Type))
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}

namespace WordSearch.Bootstrapper.Extensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Helpers.Interfaces;

    public static class ResourceWriterExtension
    {
        public static void WriteAssets(this IResourceWriterHelper resourceWriter)
        {
            var resources = GetClasses<IEmbeddableResourceBase>();

            foreach (var resource in resources)
            {
                var instance = Activator.CreateInstance(resource);

                //resourceWriter.Write((IEmbeddableResourceBase)instance);
            }
        }

        private static IEnumerable<Type> GetClasses<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(v =>
                    v.IsClass &&
                    !v.IsAbstract &&
                    typeof(T).IsAssignableFrom(v));
        }
    }
}

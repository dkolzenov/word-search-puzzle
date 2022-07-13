namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Helpers.Interfaces;
    using WordSearch.Helpers.PlatformPath;
    using WordSearch.Helpers.ResourceWriter;

    public static class HelpersRegistryExtension
    {
        public static void RegisterHelpersSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IPlatformPathHelper, PlatformPathHelper>();

            containerRegistry.RegisterSingleton<
                IResourceWriterHelper, ResourceWriterHelper>();
        }
    }
}

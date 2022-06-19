namespace WordSearch.Ioc.Modules.Helpers
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Helpers.Interfaces;
    using WordSearch.Helpers.PlatformPath;
    using WordSearch.Helpers.ResourceWriter;

    public sealed class HelpersModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IPlatformPathHelper, PlatformPathHelper>();

            containerRegistry.RegisterSingleton<
                IResourceWriterHelper, ResourceWriterHelper>();
        }
    }
}

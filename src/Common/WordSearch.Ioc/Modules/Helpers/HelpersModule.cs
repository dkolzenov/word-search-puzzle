namespace WordSearch.Ioc.Modules.Helpers
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Helpers.Interfaces;
    using WordSearch.Helpers.DatabasePath;
    using WordSearch.Helpers.EmbeddedResourceWriter;

    public sealed class HelpersModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IDatabasePathHelper, DatabasePathHelper>();

            containerRegistry.RegisterSingleton<
                IEmbeddedResourceWriterHelper, EmbeddedResourceWriterHelper>();
        }
    }
}

namespace WordSearch.Ioc.Modules
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Ioc.Modules.Data;
    using WordSearch.Ioc.Modules.Helpers;
    using WordSearch.Ioc.Modules.Presentation;
    using WordSearch.Ioc.Modules.Services;

    public sealed class IocModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            new DataModule().RegisterTypes(containerRegistry);
            new HelpersModule().RegisterTypes(containerRegistry);
            new PresentationModule().RegisterTypes(containerRegistry);
            new ServicesModule().RegisterTypes(containerRegistry);
        }
    }
}

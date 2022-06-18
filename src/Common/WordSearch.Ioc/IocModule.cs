namespace WordSearch.Ioc
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Ioc.Data;
    using WordSearch.Ioc.Helpers;
    using WordSearch.Ioc.Presentation;
    using WordSearch.Ioc.Services;

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

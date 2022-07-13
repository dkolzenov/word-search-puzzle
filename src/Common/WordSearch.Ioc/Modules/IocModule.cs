namespace WordSearch.Ioc.Modules
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Ioc.Extensions;

    public sealed class IocModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterAssetsSingleton();
            containerRegistry.RegisterRepositoriesSingleton();
            containerRegistry.RegisterHelpersSingleton();
            containerRegistry.RegisterPresentationSingleton();
            containerRegistry.RegisterServicesSingleton();
        }
    }
}

namespace WordSearch.Bootstrapper.Core
{
    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Ioc.Modules;

    internal partial class AppBootstrapper : PrismApplication
    {
        protected override void OnInitialized()
        {
        }

        protected override void ConfigureModuleCatalog(
            IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<IocModule>();
        }

        protected override void RegisterTypes(
            IContainerRegistry containerRegistry)
        {
        }
    }
}

namespace WordSearch.Bootstrapper.Core
{
    using System.Reflection;

    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Bootstrapper.Extensions;
    using WordSearch.Ioc.Modules;
    using WordSearch.Assets.Properties;
    using WordSearch.Helpers.Interfaces;

    internal partial class AppBootstrapper : PrismApplication
    {
        protected override void OnInitialized()
        {
            WriteAssets();
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

        private void WriteAssets()
        {
            var resourceWriter = Container.Resolve<IResourceWriterHelper>(
                (typeof(Assembly), _ = AssetProperties.Assembly));

            resourceWriter.WriteAssets();
        }
    }
}

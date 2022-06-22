namespace WordSearch.Bootstrapper.Core
{
    using System.Reflection;

    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Ioc.Modules;
    using WordSearch.Assets.Properties;
    using WordSearch.Assets.Databases.Constants;

    using WordSearch.Helpers.Interfaces;

    internal partial class PrismBootstrapper : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeDatabases();
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

        private void InitializeDatabases()
        {
            var resourceWriter = Container.Resolve<IResourceWriterHelper>(
                (typeof(Assembly), _ = AssetProperties.Assembly));

            resourceWriter.Write(new WordsDbConstant());
            resourceWriter.Write(new CharactersDbConstant());
        }
    }
}

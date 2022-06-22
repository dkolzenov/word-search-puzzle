namespace WordSearch.Bootstrapper.Core
{
    using System.Reflection;

    using Prism.Ioc;
    using Prism.DryIoc;
    using Prism.Modularity;

    using WordSearch.Ioc.Modules;
    using WordSearch.Data.Properties;
    using WordSearch.Data.Database.Constants;
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
            var resourceWriter = App.Current.Container.
                Resolve<IResourceWriterHelper>(
                (typeof(Assembly), _ = DataProperties.Assembly));

            resourceWriter.Write(
                WordsDbConstants.ResourceNamespace,
                WordsDbConstants.Name);

            resourceWriter.Write(
                CharactersDbConstants.ResourceNamespace,
                CharactersDbConstants.Name);
        }
    }
}

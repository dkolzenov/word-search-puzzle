namespace WordSearch.Bootstrapper.Core
{
    using System.Reflection;

    using Prism.Ioc;

    using WordSearch.Data.Properties;
    using WordSearch.Data.Database.Constants;
    using WordSearch.Helpers.Interfaces;

    internal class Startup
    {
        private readonly IResourceWriterHelper _resourceWriter;

        internal Startup()
        {
            _resourceWriter = App.Current.Container.
                Resolve<IResourceWriterHelper>(
                (typeof(Assembly), _ = DataProperties.Assembly));

            InitializeDatabases();
        }

        private void InitializeDatabases()
        {
            _resourceWriter.Write(
                WordsDbConstants.ResourceNamespace,
                WordsDbConstants.Name);

            _resourceWriter.Write(
                CharactersDbConstants.ResourceNamespace,
                CharactersDbConstants.Name);
        }
    }
}

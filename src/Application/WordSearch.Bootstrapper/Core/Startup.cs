namespace WordSearch.Bootstrapper.Core
{
    using System.Reflection;

    using Prism.Ioc;

    using WordSearch.Data.Properties;
    using WordSearch.Data.Database.Constants;
    using WordSearch.Helpers.Interfaces;

    internal class Startup
    {
        internal Startup()
        {
            InitializeDatabases();
        }

        private void InitializeDatabases()
        {
            var writerHelper = App.Current.Container.Resolve<IResourceWriterHelper>(
                (typeof(Assembly), _ = DataProperties.Assembly));

            writerHelper.Write(
                WordsDatabaseConstants.ResourceNamespace,
                WordsDatabaseConstants.Name);
        }
    }
}

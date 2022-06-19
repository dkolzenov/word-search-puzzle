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
            InitializeEmbeddedDatabases();
        }

        private void InitializeEmbeddedDatabases()
        {
            var dbPathHelper = App.Current.Container.Resolve<IDatabasePathHelper>();

            var writerHelper = App.Current.Container.Resolve<IEmbeddedResourceWriterHelper>(
                (typeof(Assembly), _ = DataProperties.Assembly),
                (typeof(string), _ = WordsDatabaseConstants.DbResourcePath));

            writerHelper.Write(dbPathHelper.GetDatabasePath(WordsDatabaseConstants.DbName));
        }
    }
}

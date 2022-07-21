namespace WordSearch.Assets.Databases
{
    using Microsoft.Extensions.Configuration;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.ResourceBase;
    using WordSearch.Assets.Databases.Extensions;
    using WordSearch.Helpers.Interfaces;

    public class WordSearchDatabase : EmbeddedResourceBase, IWordSearchDatabase
    {
        private const string DefaultConnectionKey = "DefaultConnection";

        private readonly string _name;

        private readonly string _dbConnectionString;

        public WordSearchDatabase(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper,
            IAppSettings appSettings)
            : base(platformPathHelper)
        {
            var tuple = appSettings
                .Configuration
                .GetSqliteDbResourceTuple(DefaultConnectionKey);

            _name = tuple.dbName;

            RelativeDestinationPath = tuple.dbRelativePath;

            _dbConnectionString = appSettings
                .Configuration
                .GetConnectionString(DefaultConnectionKey)
                .Replace(RelativeDestinationPath, AbsoluteDestinationPath);

            resourceWriterHelper.Write(Namespace, AbsoluteDestinationPath);
        }

        public override string Name => _name;

        public string DbConnectionString => _dbConnectionString;
    }
}

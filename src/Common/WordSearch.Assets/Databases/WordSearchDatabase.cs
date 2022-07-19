namespace WordSearch.Assets.Databases
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.DatabaseBase;
    using WordSearch.Assets.Databases.Extensions;
    using WordSearch.Helpers.Interfaces;

    public class WordSearchDatabase : DatabaseBase, IWordSearchDatabase
    {
        private const string DefaultConnectionName = "DefaultConnection";

        private readonly string _name;

        private readonly string _dbConnectionString;

        private readonly SqliteConnectionStringInfo _connectionStringInfo;

        public WordSearchDatabase(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper,
            IAppSettings appSettings)
            : base(platformPathHelper)
        {
            var configuration = appSettings.Configuration;

            _connectionStringInfo = configuration
                .GetSqliteConnectionStringInfo(DefaultConnectionName);

            _name = _connectionStringInfo.DatabaseName;

            RelativeDestinationPath = _connectionStringInfo.DatabaseRelativePath;

            _dbConnectionString = $"{_connectionStringInfo.Keyword}" +
                $"={AbsoluteDestinationPath}" +
                $"{_connectionStringInfo.AdditionalParameters}";

            resourceWriterHelper.Write(Namespace, AbsoluteDestinationPath);
        }

        public override string Name => _name;

        public override string DbConnectionString => _dbConnectionString;
    }
}

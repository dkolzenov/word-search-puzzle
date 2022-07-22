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

        public WordSearchDatabase(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper,
            IAppSettings appSettings)
            : base(platformPathHelper)
        {
            (string dbName, string dbRelativePath) = appSettings
                .Configuration
                .GetSqliteDbResourceTuple(DefaultConnectionKey);

            Name = dbName;

            RelativeDestinationPath = dbRelativePath;

            DbConnectionString = appSettings
                .Configuration
                .GetConnectionString(DefaultConnectionKey)
                .Replace(RelativeDestinationPath, AbsoluteDestinationPath);

            resourceWriterHelper.Write(Namespace, AbsoluteDestinationPath);
        }

        public override string Name { get; }

        public string DbConnectionString { get; }
    }
}

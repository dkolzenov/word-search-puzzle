namespace WordSearch.Data.Database.Constants
{
    using WordSearch.Data.Properties;

    public static class WordsDatabaseConstants
    {
        public const string DbName = "Words.db";

        public static readonly string DbResourcePath;

        static WordsDatabaseConstants()
        {
            var assemblyName = DataProperties.Assembly.GetName().Name;

            DbResourcePath = $"{assemblyName}.Database.{DbName}";
        }
    }
}

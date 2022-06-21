namespace WordSearch.Data.Database.Constants
{
    using WordSearch.Data.Properties;

    public static class WordsDbConstants
    {
        public const string Name = "Words.db";

        public static readonly string ResourceNamespace;

        static WordsDbConstants()
        {
            var assemblyName = DataProperties.Assembly.GetName().Name;

            ResourceNamespace = $"{assemblyName}.Database.{Name}";
        }
    }
}

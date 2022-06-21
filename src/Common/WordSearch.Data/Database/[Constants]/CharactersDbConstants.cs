namespace WordSearch.Data.Database.Constants
{
    using WordSearch.Data.Properties;

    public static class CharactersDbConstants
    {
        public const string Name = "Characters.db";

        public static readonly string ResourceNamespace;

        static CharactersDbConstants()
        {
            var assemblyName = DataProperties.Assembly.GetName().Name;

            ResourceNamespace = $"{assemblyName}.Database.{Name}";
        }
    }
}

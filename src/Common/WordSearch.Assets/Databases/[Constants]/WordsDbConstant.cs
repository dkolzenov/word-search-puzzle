namespace WordSearch.Assets.Databases.Constants
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Properties;

    public class WordsDbConstant : IResourceConstant
    {
        private static readonly string _assemblyName;

        static WordsDbConstant() =>
            _assemblyName = AssetProperties.Assembly.GetName().Name;

        public string Name => "Words.db";

        public string Namespace => $"{_assemblyName}.Databases.{Name}";
    }
}

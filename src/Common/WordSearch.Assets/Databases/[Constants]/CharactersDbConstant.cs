namespace WordSearch.Assets.Databases.Constants
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Properties;

    public class CharactersDbConstant : IResourceConstant
    {
        private static readonly string _assemblyName;

        static CharactersDbConstant() =>
            _assemblyName = AssetProperties.Assembly.GetName().Name;

        public string Name => "Characters.db";

        public string Namespace => $"{_assemblyName}.Databases.{Name}";
    }
}

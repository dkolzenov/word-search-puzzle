namespace WordSearch.Assets.Databases
{
    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Base;

    public class WordSearchDbResource : EmbeddedResourceBase, IWordSearchDbResource
    {
        public override string Name => "WordSearch.db";

        public override string RelativePath => $"{Name}";
    }
}

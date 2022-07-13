namespace WordSearch.Assets.Interfaces
{
    public interface IEmbeddableResourceBase
    {
        string Name { get; }

        string Namespace { get; }

        string RelativePath { get; }

        string AbsolutePath { get; }
    }
}

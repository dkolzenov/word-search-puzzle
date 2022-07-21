namespace WordSearch.Assets.Interfaces
{
    public interface IWordSearchDatabase : IEmbeddableResourceBase
    {
        string DbConnectionString { get; }
    }
}

namespace WordSearch.Assets.Interfaces
{
    public interface IDatabasableBase : IEmbeddableResourceBase
    {
        string DbConnectionString { get; }
    }
}

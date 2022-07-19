namespace WordSearch.Assets.Interfaces
{
    using Microsoft.Extensions.Configuration;

    public interface IAppSettings : IEmbeddableResourceBase
    {
        IConfiguration Configuration { get; }
    }
}

namespace WordSearch.Assets.Interfaces
{
    public interface IEmbeddableResourceBase
    {
        string Name { get; }

        string Namespace { get; }

        string RelativeDestinationPath { get; }

        string AbsoluteDestinationPath { get; }
    }
}

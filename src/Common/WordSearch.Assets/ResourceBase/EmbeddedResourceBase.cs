namespace WordSearch.Assets.ResourceBase
{
    using System.IO;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Helpers.Interfaces;

    public abstract class EmbeddedResourceBase : IEmbeddableResourceBase
    {
        private readonly string _platformPath;

        private string _relativeDestinationPath;

        protected EmbeddedResourceBase(IPlatformPathHelper platformPathHelper)
        {
            _platformPath = platformPathHelper.Path;

            _relativeDestinationPath = Name;
        }

        protected EmbeddedResourceBase(
            IPlatformPathHelper platformPathHelper,
            IResourceWriterHelper resourceWriterHelper)
            : this(platformPathHelper)
        {
            resourceWriterHelper.Write(Namespace, AbsoluteDestinationPath);
        }

        public string Namespace => $"{GetType().Namespace}.{Name}";

        public string AbsoluteDestinationPath => Path.Join(
            _platformPath, RelativeDestinationPath);

        public string RelativeDestinationPath
        {
            get => _relativeDestinationPath;

            set => _relativeDestinationPath = Path.Join(value, Name);
        }

        public abstract string Name { get; }
    }
}

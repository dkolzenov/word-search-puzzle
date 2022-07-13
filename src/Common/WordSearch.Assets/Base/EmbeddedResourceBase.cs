namespace WordSearch.Assets.Base
{
    using System;
    using System.IO;

    using WordSearch.Assets.Interfaces;

    public abstract class EmbeddedResourceBase : IEmbeddableResourceBase
    {
        public abstract string Name { get; }

        public abstract string RelativePath { get; }

        public string Namespace => $"{GetType().Namespace}.{Name}";

        public string AbsolutePath => Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
                RelativePath);
    }
}

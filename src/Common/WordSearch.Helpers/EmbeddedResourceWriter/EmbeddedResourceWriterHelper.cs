namespace WordSearch.Helpers.EmbeddedResourceWriter
{
    using System.IO;
    using System.Reflection;

    using WordSearch.Helpers.Interfaces;

    public class EmbeddedResourceWriterHelper : IEmbeddedResourceWriterHelper
    {
        private readonly string _resourcePath;

        private readonly Assembly _assembly;

        public EmbeddedResourceWriterHelper(Assembly assembly, string resourcePath)
        {
            _resourcePath = resourcePath;
            _assembly = assembly;
        }

        public void Write(string databasePath)
        {
            if (!File.Exists(databasePath))
            {
                using (Stream stream = _assembly.GetManifestResourceStream(_resourcePath))
                {
                    using (var fs = new FileStream(databasePath, FileMode.OpenOrCreate))
                    {
                        stream.CopyTo(fs);
                    }
                }
            }
        }
    }
}

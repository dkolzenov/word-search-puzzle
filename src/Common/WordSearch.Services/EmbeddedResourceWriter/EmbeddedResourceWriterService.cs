namespace WordSearch.Services.EmbeddedResourceWriter
{
    using System.IO;
    using System.Reflection;

    using WordSearch.Services.Interfaces;

    public class EmbeddedResourceWriterService : IEmbeddedResourceWriterService
    {
        private readonly string _resourcePath;

        private readonly Assembly _assembly;

        public EmbeddedResourceWriterService(Assembly assembly, string resourcePath)
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

namespace WordSearch.Helpers.ResourceWriter
{
    using System.IO;
    using System.Reflection;

    using WordSearch.Helpers.Interfaces;

    public class ResourceWriterHelper : IResourceWriterHelper
    {
        private readonly Assembly _assembly;

        public ResourceWriterHelper(Assembly assembly)
        {
            _assembly = assembly;
        }

        public void Write(string namespacePath, string resourceDestinationPath)
        {
            if (!File.Exists(resourceDestinationPath))
            {
                using (Stream stream = _assembly
                    .GetManifestResourceStream(namespacePath))
                {
                    using (var fs = new FileStream(
                        resourceDestinationPath,
                        FileMode.OpenOrCreate))
                    {
                        stream.CopyTo(fs);
                    }
                }
            }
        }
    }
}

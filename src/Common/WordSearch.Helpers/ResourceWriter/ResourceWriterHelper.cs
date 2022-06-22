namespace WordSearch.Helpers.ResourceWriter
{
    using System.IO;
    using System.Reflection;

    using WordSearch.Helpers.Interfaces;
    using WordSearch.Assets.Interfaces;

    public class ResourceWriterHelper : IResourceWriterHelper
    {
        private readonly Assembly _assembly;

        private readonly IPlatformPathHelper _pathHelper;

        public ResourceWriterHelper(
            Assembly assembly,
            IPlatformPathHelper pathHelper)
        {
            _assembly = assembly;
            _pathHelper = pathHelper;
        }

        public void Write(IResourceConstant resourceConstant)
        {
            var platformPath = Path.Combine(_pathHelper.Path, resourceConstant.Name);

            if (!File.Exists(platformPath))
            {
                using (Stream stream = _assembly.GetManifestResourceStream(
                    resourceConstant.Namespace))
                {
                    using (var fs = new FileStream(
                        platformPath,
                        FileMode.OpenOrCreate))
                    {
                        stream.CopyTo(fs);
                    }
                }
            }
        }
    }
}

namespace WordSearch.Helpers.PlatformPath
{
    using System;

    using WordSearch.Helpers.Interfaces;

    public class PlatformPathHelper : IPlatformPathHelper
    {
        public string Path { get; }

        public PlatformPathHelper()
        {
            Path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
        }
    }
}

using Xamarin.Essentials;

namespace WordSearch.Application.Common.Helpers
{
    /// <summary>
    /// Помощник получения пути в зависимости от конкретной платформы
    /// </summary>
    public static class PlatformPathHelper
    {
        /// <summary>
        /// Путь
        /// </summary>
        public static string Path { get; }

        static PlatformPathHelper()
        {
            Path = FileSystem.AppDataDirectory;
        }
    }
}

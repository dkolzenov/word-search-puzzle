using System.IO;
using Microsoft.Extensions.Configuration;
using WordSearch.Application.Common.Helpers;

namespace WordSearch.Bootstrapper
{
    /// <summary>
    /// Настройки приложения
    /// </summary>
    public static class AppSettings
    {
        private const string Name = "appsettings.json";

        /// <summary>
        /// Конфигурация
        /// </summary>
        public static IConfiguration Configuration { get; }

        static AppSettings()
        {
            var fullPath = Path.Join(PlatformPathHelper.Path, Name);

            ResourceWriteHelper.Write($"{typeof(AppSettings).Namespace}.{Name}", fullPath);

            Configuration = new ConfigurationBuilder()
                .AddJsonFile(fullPath)
                .Build();
        }
    }
}

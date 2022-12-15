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
        private const string FileName = "appsettings.json";

        /// <summary>
        /// Конфигурация
        /// </summary>
        public static IConfiguration Configuration { get; }

        static AppSettings()
        {
            var destinationPath = Path.Join(PlatformPathHelper.Path, FileName);

            ResourceWriteHelper.Write($"{typeof(AppSettings).Namespace}.{FileName}", destinationPath);
            Configuration = new ConfigurationBuilder()
                .AddJsonFile(destinationPath)
                .Build();
        }
    }
}

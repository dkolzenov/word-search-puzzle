using System.IO;
using System.Reflection;

namespace WordSearch.Application.Common.Helpers
{
    /// <summary>
    /// Помощник записи встроенных ресурсов
    /// </summary>
    public static class ResourceWriteHelper
    {
        /// <summary>
        /// Запись ресурса
        /// </summary>
        /// <param name="namespacePath"> Путь к пространству имён ресурса </param>
        /// <param name="destinationPath"> Путь назначения ресурса </param>
        public static void Write(string namespacePath, string destinationPath)
        {
            if (!File.Exists(destinationPath))
            {
                using var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(namespacePath)!;

                var dir = Path.GetDirectoryName(destinationPath)!;

                Directory.CreateDirectory(dir);

                using var fileStream = new FileStream(destinationPath, FileMode.OpenOrCreate);

                stream.CopyTo(fileStream);
            }
        }
    }
}

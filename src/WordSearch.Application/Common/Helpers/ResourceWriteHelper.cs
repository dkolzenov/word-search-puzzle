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
        /// Запись
        /// </summary>
        /// <param name="namespacePath"> Путь к пространству имён </param>
        /// <param name="resourceDestinationPath"> Путь назначения ресурса </param>
        public static void Write(string namespacePath, string resourceDestinationPath)
        {
            if (!File.Exists(resourceDestinationPath))
            {
                using var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(namespacePath)!;

                var dir = Path.GetDirectoryName(resourceDestinationPath)!;

                Directory.CreateDirectory(dir);

                using var fileStream = new FileStream(resourceDestinationPath, FileMode.OpenOrCreate);

                stream.CopyTo(fileStream);
            }
        }
    }
}

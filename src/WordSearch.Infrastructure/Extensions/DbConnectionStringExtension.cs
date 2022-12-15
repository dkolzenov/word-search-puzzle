using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using WordSearch.Application.Common.Helpers;

namespace WordSearch.Infrastructure.Extensions
{
    public static class DbConnectionStringExtension
    {
        private const string DbKeywords = @"Data Source|DataSource|Filename";
        
        private const string DbExtensions = @".db|.db3|.sqlite|.sqlite3";

        private const string SplitSeparator = "=";

        private static readonly Regex Regex;

        static DbConnectionStringExtension()
        {
            Regex = new Regex($@"({DbKeywords})\S+({DbExtensions})");
        }

        public static string? GetPlatformSpecificDbConnectionString(this IConfiguration configuration, string connectionStringKey)
        {
            var connectionString = configuration.GetConnectionString(connectionStringKey);
            var matchString = Regex.Match(connectionString!).Value;
            var splitString = matchString.Split(SplitSeparator);

            return connectionString?.Replace(matchString,
                string.Join(SplitSeparator, splitString[0], Path.Join(PlatformPathHelper.Path, splitString[1])));
        }
    }
}

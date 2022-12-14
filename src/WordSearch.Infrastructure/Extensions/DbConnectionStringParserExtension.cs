using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;

namespace WordSearch.Infrastructure.Extensions
{
    public static class DbConnectionStringParserExtension
    {
        private const string DbExtensions = @".db|.db3|.sqlite|.sqlite3";

        private const string SplitSeparator = "=";

        private static readonly Regex Regex;

        static DbConnectionStringParserExtension()
        {
            var dbNamePattern = $@"\w+({DbExtensions})";

            Regex = new Regex(dbNamePattern);
        }

        public static (string dbName, string dbRelativePath) GetSqliteParseDbConnectionStringTuple(
            this IConfiguration configuration, string connectionStringKey)
        {
            var connectionString = configuration.GetConnectionString(connectionStringKey);
            var tuple = (connectionString!.GetDatabaseName(), connectionString!.GetDatabaseRelativePath());

            return tuple;
        }

        private static string GetDatabaseName(this string connectionString)
        {
            var dbName = Regex.Match(connectionString).Value;

            return dbName;
        }

        private static string GetDatabaseRelativePath(this string connectionString)
        {
            var splitConnectionString = connectionString.Split(SplitSeparator);
            var doubleSplitConnectionString = Regex.Split(splitConnectionString[1]);
            var dbRelativePath = doubleSplitConnectionString[0];

            return dbRelativePath;
        }
    }
}

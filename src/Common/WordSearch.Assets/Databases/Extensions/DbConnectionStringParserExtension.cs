namespace WordSearch.Assets.Databases.Extensions
{
    using System;
    using System.Text.RegularExpressions;

    using Microsoft.Extensions.Configuration;

    public static class DbConnectionStringParserExtension
    {
        private const string DbExtensions = @".db|.db3|.sqlite";

        private const string SplitSeparator = "=";

        private static readonly string _dbNamePattern;

        private static readonly Regex _regex;

        static DbConnectionStringParserExtension()
        {
            _dbNamePattern = $@"\w+({DbExtensions})";

            _regex = new Regex(_dbNamePattern);
        }

        public static (string dbName, string dbRelativePath) GetSqliteDbResourceTuple(
            this IConfiguration configuration,
            string connectionStringKey)
        {
            try
            {
                string connectionString = configuration
                    .GetConnectionString(connectionStringKey);

                (string, string) tuple = (
                    connectionString.GetDatabaseName(),
                    connectionString.GetDatabaseRelativePath());

                return tuple;
            }
            catch (Exception ex)
            {
                // поменяй это, так не обрабатывают исключения!
                throw new Exception(ex.Message);
            }
        }

        private static string GetDatabaseName(this string connectionString)
        {
            string dbName = _regex.Match(connectionString).Value;

            return dbName;
        }

        private static string GetDatabaseRelativePath(
            this string connectionString)
        {
            string[] splitConnectionString = connectionString
                .Split(SplitSeparator);

            string[] doubleSplitConnectionString = _regex
                .Split(splitConnectionString[1]);

            string dbRelativePath = doubleSplitConnectionString[0];

            return dbRelativePath;
        }
    }
}

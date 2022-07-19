namespace WordSearch.Assets.Databases.Extensions
{
    using System;
    using System.Text.RegularExpressions;

    using Microsoft.Extensions.Configuration;

    public static class SqliteConnectionStringParserExtension
    {
        private const string DbExtensions = @".db|.db3|.sqlite";

        private const string SplitSeparator = "=";

        private static string _connectionString = null!;

        private static readonly string _dbNamePattern;

        private static readonly Regex _regex;

        static SqliteConnectionStringParserExtension()
        {
            _dbNamePattern = $@"\w+({DbExtensions})";

            _regex = new Regex(_dbNamePattern);
        }

        public static SqliteConnectionStringInfo GetSqliteConnectionStringInfo(
            this IConfiguration configuration,
            string connectionStringKey)
        {
            try
            {
                _connectionString = configuration
                    .GetConnectionString(connectionStringKey);

                return new SqliteConnectionStringInfo()
                {
                    Keyword = GetKeyword(),
                    DatabaseName = GetDatabaseName(),
                    DatabaseRelativePath = GetDatabaseRelativePath(),
                    AdditionalParameters = GetAdditionalParameters()
                };
            }
            catch (Exception ex)
            {
                // поменяй это, так не обрабатывают исключения!
                throw new Exception(ex.Message);
            }
        }

        private static string GetKeyword()
        {
            string[] splitConnectionString = _connectionString
                    .Split(SplitSeparator);

            string keyword = splitConnectionString[0];

            return keyword;
        }

        private static string GetDatabaseName()
        {
            string dbName = _regex.Match(_connectionString).Value;

            return dbName;
        }

        private static string GetDatabaseRelativePath()
        {
            string[] splitConnectionString = _connectionString
                .Split(SplitSeparator);

            string[] doubleSplitConnectionString = _regex
                .Split(splitConnectionString[1]);

            string dbRelativePath = doubleSplitConnectionString[0];

            return dbRelativePath;
        }

        private static string GetAdditionalParameters()
        {
            string[] splitConnectionString = _regex.Split(_connectionString);

            string additionalParameters = splitConnectionString[2];

            return additionalParameters;
        }
    }

    public class SqliteConnectionStringInfo
    {
        public string Keyword { get; internal set; } = null!;

        public string DatabaseName { get; internal set; } = null!;

        public string DatabaseRelativePath { get; internal set; } = null!;

        public string AdditionalParameters { get; internal set; } = null!;
    }
}

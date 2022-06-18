namespace WordSearch.Helpers.DatabasePath
{
    using System;
    using System.IO;

    using WordSearch.Helpers.Interfaces;

    public class DatabasePathHelper : IDatabasePathHelper
    {
        public string GetDatabasePath(string databaseName)
        {
            return Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
                databaseName);
        }
    }
}

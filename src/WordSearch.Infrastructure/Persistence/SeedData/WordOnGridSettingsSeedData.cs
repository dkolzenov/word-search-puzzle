using System.Collections.Generic;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class WordOnGridSettingsSeedData
    {
        private static readonly IEnumerable<WordOnGridSettings> WordOnGridSettingsList;

        static WordOnGridSettingsSeedData()
        {
            WordOnGridSettingsList = new List<WordOnGridSettings>
            {
                new WordOnGridSettings
                {
                    Id = 1,
                    WordCount = 1,
                    WordLength = 3,
                    GameSessionSettingsId = 1
                },
                new WordOnGridSettings
                {
                    Id = 2,
                    WordCount = 1,
                    WordLength = 4,
                    GameSessionSettingsId = 1
                }
            };
        }

        public static IEnumerable<WordOnGridSettings> Get() => WordOnGridSettingsList;
    }
}

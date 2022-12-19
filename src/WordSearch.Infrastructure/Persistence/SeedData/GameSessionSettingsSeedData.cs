using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class GameSessionSettingsSeedData
    {
        private static readonly IEnumerable<GameSessionSettings> GameSessionSettingsList;

        static GameSessionSettingsSeedData()
        {
            GameSessionSettingsList = new List<GameSessionSettings>
            {
                new GameSessionSettings
                {
                    Id = 1,
                    GridSettingsId = 1,
                    Difficulty = GameDifficulty.Easy
                },
                new GameSessionSettings
                {
                    Id = 2,
                    GridSettingsId = 2,
                    Difficulty = GameDifficulty.Medium
                },
                new GameSessionSettings
                {
                    Id = 3,
                    GridSettingsId = 3,
                    Difficulty = GameDifficulty.Hard
                }
            };
        }

        public static IEnumerable<GameSessionSettings> Get() => GameSessionSettingsList;
    }
}

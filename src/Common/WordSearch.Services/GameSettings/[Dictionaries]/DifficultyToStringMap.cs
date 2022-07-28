namespace WordSearch.Services.GameSettings.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.GameSettings.Enums;

    public class DifficultyToStringMap
    {
        private readonly Dictionary<DifficultyType, string> _map;

        public DifficultyToStringMap()
        {
            _map = new Dictionary<DifficultyType, string>()
            {
                {DifficultyType.Easy, "easy"},
                {DifficultyType.Normal, "normal"},
                {DifficultyType.Hard, "hard"},
            };
        }

        public string GetDifficultyString(DifficultyType difficultyType)
        {
            return _map[difficultyType];
        }
    }
}

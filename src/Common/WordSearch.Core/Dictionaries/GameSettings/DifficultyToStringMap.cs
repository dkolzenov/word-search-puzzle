namespace WordSearch.Core.Dictionaries.GameSettings
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.GameSettings;

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

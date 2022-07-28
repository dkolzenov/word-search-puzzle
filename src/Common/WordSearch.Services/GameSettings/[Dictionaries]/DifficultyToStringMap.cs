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
                {DifficultyType.Easy, "Легко"},
                {DifficultyType.Easy, "Easy"},

                {DifficultyType.Normal, "Нормально"},
                {DifficultyType.Normal, "Normal"},

                {DifficultyType.Hard, "Тяжело"},
                {DifficultyType.Hard, "Hard"},
            };
        }

        public string GetItemString(DifficultyType difficultyType)
        {
            return _map[difficultyType];
        }
    }
}

namespace WordSearch.Models.GameSettings
{
    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.Grid;
    using WordSearch.Core.Enums.GameSettings;

    public class GameSettingsModel
    {
        public LanguageType WordLanguage { get; set; }

        public CategoryType WordCategory { get; set; }

        public DifficultyType Difficulty { get; set; }

        public SizeType GridSize { get; set; }

        public int WordCount { get; set; }

        public int MaxWordLength { get; set; }

        // TODO: Future updates

        //public int TimeLimit { get; set; }

        //public int ScoreMultiplier { get; set; }
    }
}

namespace WordSearch.Models.GameSettings
{
    public class GameSettingsModel
    {
        public string WordLanguage { get; set; } = null!;

        public string WordCategory { get; set; } = null!;

        public string Difficulty { get; set; } = null!;

        public string GridSize { get; set; } = null!;

        public int WordCount { get; set; }

        public int MaxWordLength { get; set; }

        // TODO: Future updates

        //public int TimeLimit { get; set; }

        //public int ScoreMultiplier { get; set; }
    }
}

namespace WordSearch.Models.GameSettings
{
    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.GameSettings;

    public class GameSettingsSelectionModel
    {
        public LanguageType WordLanguage { get; set; }

        public CategoryType WordCategory { get; set; }

        public DifficultyType Difficulty { get; set; }
    }
}

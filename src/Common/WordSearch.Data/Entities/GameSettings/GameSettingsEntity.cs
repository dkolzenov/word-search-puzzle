namespace WordSearch.Data.Entities.GameSettings
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GameSettings")]
    public class GameSettingsEntity
    {
        public int Id { get; set; }

        public string Difficulty { get; set; } = null!;

        public string GridSize { get; set; } = null!;

        public int WordCount { get; set; }

        public int MaxWordLength { get; set; }

        // TODO: Future updates

        //public int TimeLimit { get; set; }

        //public int ScoreMultiplier { get; set; }
    }
}

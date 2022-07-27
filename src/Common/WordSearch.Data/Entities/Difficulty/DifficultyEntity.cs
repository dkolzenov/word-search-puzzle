namespace WordSearch.Data.Entities.Difficulty
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Difficulties")]
    public class DifficultyEntity
    {
        public int Id { get; set; }

        public string Value { get; set; } = null!;

        public string GridSize { get; set; } = null!;

        public int WordCount { get; set; }

        public int MaxWordLength { get; set; }

        // TODO: Future updates

        //public int TimeLimit { get; set; }

        //public int ScoreMultiplier { get; set; }
    }
}

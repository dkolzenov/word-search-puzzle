namespace WordSearch.Data.Entities.WordOnGrid
{
    using System.ComponentModel.DataAnnotations.Schema;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.Direction;

    [Table("WordOnGrid")]
    public class WordOnGridEntity
    {
        public int Id { get; set; }

        public WordEntity Word { get; set; } = null!;

        public DirectionEntity Direction { get; set; } = null!;
    }
}

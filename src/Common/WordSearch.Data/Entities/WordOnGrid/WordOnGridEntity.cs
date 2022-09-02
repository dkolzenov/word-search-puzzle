namespace WordSearch.Data.Entities.WordOnGrid
{
    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.Direction;

    public class WordOnGridEntity
    {
        public int Id { get; set; }

        public WordEntity Word { get; set; } = null!;

        public DirectionEntity Direction { get; set; } = null!;
    }
}

namespace WordSearch.Models.WordOnGrid
{
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Direction;

    public class WordOnGridModel
    {
        public WordModel Word { get; set; } = null!;

        public CellModel StartCell { get; set; } = null!;

        public DirectionModel Direction { get; set; } = null!;
    }
}

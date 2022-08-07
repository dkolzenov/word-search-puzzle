namespace WordSearch.Models.Direction
{
    using WordSearch.Core.Enums.Direction;

    public class DirectionModel
    {
        public int RowMovement { get; set; }

        public int ColumnMovement { get; set; }

        public LayoutType Layout { get; set; }

        public string DirectionType { get; set; } = null!;
    }
}

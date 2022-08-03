namespace WordSearch.Models.Direction
{
    public class DirectionModel
    {
        public int RowMovement { get; set; }

        public int ColumnMovement { get; set; }

        public string LayoutType { get; set; } = null!;

        public string DirectionType { get; set; } = null!;
    }
}

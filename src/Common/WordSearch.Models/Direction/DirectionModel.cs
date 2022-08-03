namespace WordSearch.Models.Direction
{
    public class DirectionModel
    {
        public int RowMovement { get; set; }

        public int ColumnMovement { get; set; }

        public string Layout { get; set; } = null!;

        public string DirectionType { get; set; } = null!;
    }
}

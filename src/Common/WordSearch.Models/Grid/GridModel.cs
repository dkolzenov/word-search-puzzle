namespace WordSearch.Models.Grid
{
    using WordSearch.Models.Cell;

    public class GridModel
    {
        public int Id { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public string Size { get; set; } = null!;

        public CellModel[,] Array { get; set; } = null!;
    }
}

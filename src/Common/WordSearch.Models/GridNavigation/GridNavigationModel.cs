namespace WordSearch.Models.GridNavigation
{
    using WordSearch.Models.Grid;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Direction;

    public class GridNavigationModel
    {
        public GridModel Grid { get; set; } = null!;

        public CellModel StartPointCell { get; set; } = null!;

        public DirectionModel Direction { get; set; } = null!;
    }
}

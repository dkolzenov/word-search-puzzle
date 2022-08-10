namespace WordSearch.Services.GridNavigation
{
    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GridNavigation;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Direction;

    public class GridNavigationService : IGridNavigationService
    {
        public bool Move(ref GridNavigationModel gridNavigation)
        {
            GridModel grid = gridNavigation.Grid;
            CellModel cell = gridNavigation.StartPointCell;
            DirectionModel direction = gridNavigation.Direction;

            cell.Row += direction.RowMovement;
            cell.Column += direction.ColumnMovement;

            if (cell.Row > grid.Row || cell.Column > grid.Column)
                return false;

            gridNavigation.StartPointCell = cell;

            return true;
        }
    }
}

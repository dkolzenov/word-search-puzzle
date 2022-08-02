namespace WordSearch.Services.Interfaces
{
    using WordSearch.Models.Cell;

    public interface ICellService
    {
        CellModel[,] GetTwoDimensionalCellArray(int row, int column);
    }
}

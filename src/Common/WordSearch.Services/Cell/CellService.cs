namespace WordSearch.Services.Cell
{
    using WordSearch.Services.Interfaces;
    using WordSearch.Models.Cell;

    public class CellService : ICellService
    {
        public CellModel[,] GetTwoDimensionalCellArray(int row, int column)
        {
            var cellArray = new CellModel[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var cell = new CellModel()
                    {
                        Row = i + 1,
                        Column = j + 1
                    };
                    cellArray[i, j] = cell;
                }
            }
            return cellArray;
        }
    }
}

namespace WordSearch.Services.Cell
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.Cell;

    public class CellService : ICellService
    {
        public Task<List<CellModel>> GetCellsAsync(int row, int column)
        {
            var cells = new List<CellModel>();

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    var cell = new CellModel()
                    {
                        Row = i,
                        Column = j
                    };
                    cells.Add(cell);
                }
            }
            return Task.FromResult(cells);
        }
    }
}

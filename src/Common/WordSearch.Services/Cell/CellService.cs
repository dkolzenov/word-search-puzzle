namespace WordSearch.Services.Cell
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.Cell;

    public class CellService : ICellService
    {
        public Task<List<CellModel>> GetCellList(int count)
        {
            var cellList = new List<CellModel>();

            for (int i = 0; i < count; i++)
            {
                var cell = new CellModel();

                cellList.Add(cell);
            }
            return Task.FromResult(cellList);
        }
    }
}

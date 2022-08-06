namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Cell;

    public interface ICellService
    {
        Task<List<CellModel>> GetCells(int row, int column);
    }
}

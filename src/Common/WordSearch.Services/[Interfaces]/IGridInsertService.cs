namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.Grid;
    using WordSearch.Models.GridData;

    public interface IGridInsertService
    {
        Task<GridModel> GetDataInsertedGridAsync(
            GridModel grid,
            GridDataModel gridData);
    }
}

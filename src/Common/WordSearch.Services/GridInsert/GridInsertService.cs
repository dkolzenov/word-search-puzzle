namespace WordSearch.Services.GridInsert
{
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.GridInsert.Extensions;
    using WordSearch.Models.Grid;
    using WordSearch.Models.GridData;

    public class GridInsertService : IGridInsertService
    {
        public GridInsertService()
        {

        }

        public Task<GridModel> GetDataInsertedGridAsync(GridModel grid, GridDataModel gridData)
        {
            throw new System.NotImplementedException();
        }
    }
}

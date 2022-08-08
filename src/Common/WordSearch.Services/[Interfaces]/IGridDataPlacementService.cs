namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.GridData;
    using WordSearch.Models.GridDataPlacement;

    public interface IGridDataPlacementService
    {
        Task<GridDataPlacementModel> GetGridDataPlacementAsync(
            GridDataModel gridData);
    }
}

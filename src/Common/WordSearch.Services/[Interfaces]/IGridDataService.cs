namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.DataGrid;
    using WordSearch.Models.GameSettings;

    public interface IGridDataService
    {
        Task<GridDataModel> GetGridData(GameSettingsModel gameSettings);
    }
}

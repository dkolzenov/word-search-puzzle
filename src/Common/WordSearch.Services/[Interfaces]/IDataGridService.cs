namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.DataGrid;
    using WordSearch.Models.GridData;
    using WordSearch.Models.Grid;

    public interface IDataGridService
    {
        Task<DataGridModel> GetDataGridAsync(
            GridModel grid,
            GridDataModel gridData);
    }
}

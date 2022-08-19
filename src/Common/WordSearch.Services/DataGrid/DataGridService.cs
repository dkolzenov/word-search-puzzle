namespace WordSearch.Services.DataGrid
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.DataGrid;
    using WordSearch.Models.GridData;
    using WordSearch.Models.Grid;

    public class DataGridService : IDataGridService
    {
        public DataGridService()
        {

        }

        public async Task<DataGridModel> GetDataGridAsync(
            GridModel grid,
            GridDataModel gridData)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return await Task.FromException<DataGridModel>(
                    ex.InnerException);
            }
        }
    }
}

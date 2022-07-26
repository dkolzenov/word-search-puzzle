namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Services.Grid.Enums;
    using WordSearch.Models.Grid;

    public interface IGridService
    {
        Task<GridModel> GetGrid(SizeType size);
    }
}

namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.Grid;
    using WordSearch.Core.Enums.Grid;

    public interface IGridService
    {
        Task<GridModel> GetGridAsync(SizeType size);
    }
}

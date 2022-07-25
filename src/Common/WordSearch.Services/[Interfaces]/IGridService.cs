namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Services.Grid.Enums;
    using WordSearch.Data.Entities.Grid;

    public interface IGridService
    {
        Task<GridEntity> GetGrid(SizeType size);
    }
}

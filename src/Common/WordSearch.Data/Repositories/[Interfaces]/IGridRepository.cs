namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Data.Entities.Grid;
    using WordSearch.Core.Enums.Grid;

    public interface IGridRepository : IRepositoryBase<GridEntity>
    {
        Task<GridEntity> GetGridAsync(SizeType sizeType);
    }
}

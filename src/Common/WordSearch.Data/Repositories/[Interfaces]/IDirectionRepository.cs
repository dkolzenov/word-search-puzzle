namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Data.Entities.Direction;
    using WordSearch.Core.Enums.Direction;

    public interface IDirectionRepository : IRepositoryBase<DirectionEntity>
    {
        Task<List<DirectionEntity>> GetDirectionsAsync(LayoutType layoutType);
    }
}

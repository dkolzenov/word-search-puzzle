namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Direction.Enums;
    using WordSearch.Models.Direction;

    public interface IDirectionService
    {
        Task<List<DirectionModel>> GetDirections(LayoutType layoutType);
    }
}

namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Direction;
    using WordSearch.Core.Enums.Direction;

    public interface IDirectionService
    {
        Task<List<DirectionModel>> GetDirections(LayoutType layoutType);
    }
}

namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Direction;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Core.Enums.Direction;

    public interface IDirectionService
    {
        Task<List<DirectionModel>> GetDirectionsAsync(LayoutType layoutType);

        Task<DirectionModel?> GetValidRandomWordDirectionAsync(
            GridModel grid,
            WordModel word,
            CellModel startCell);
    }
}

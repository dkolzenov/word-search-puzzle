namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Direction;

    public interface IWordDirectionService
    {
        Task<DirectionModel> GetValidRandomDirection(
            GridModel grid,
            WordModel word,
            CellModel startCell);
    }
}

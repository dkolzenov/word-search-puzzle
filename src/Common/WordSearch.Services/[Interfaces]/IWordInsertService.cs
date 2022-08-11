namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;

    public interface IWordInsertService
    {
        Task<GridModel> GetWordInsertedGrid(GridModel grid, WordModel word);
    }
}

namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.WordOnGrid;

    public interface IWordOnGridService
    {
        Task<List<WordOnGridModel>> GetWordsOnGridAsync();

        Task<WordOnGridModel> AddWordOnGridAsync();
    }
}

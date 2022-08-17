namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Word;
    using WordSearch.Core.Enums.Word;

    public interface IWordService
    {
        Task<List<WordModel>> GetWordsAsync(
            LanguageType languageType,
            CategoryType categoryType,
            int maxLength = int.MaxValue);

        Task<List<WordModel>> GetRandomWordsAsync(
            LanguageType languageType,
            CategoryType categoryType,
            int count,
            int maxLength = int.MaxValue);
    }
}

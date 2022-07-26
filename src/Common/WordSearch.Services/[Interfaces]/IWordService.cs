namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Models.Word;

    public interface IWordService
    {
        Task<List<WordModel>> GetWords(
            LanguageType languageType,
            CategoryType categoryType);
    }
}

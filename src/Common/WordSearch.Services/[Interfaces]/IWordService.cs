namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Word.Enums;

    public interface IWordService
    {
        Task<List<string>> GetWords(
            LanguageType languageType,
            CategoryType categoryType);
    }
}

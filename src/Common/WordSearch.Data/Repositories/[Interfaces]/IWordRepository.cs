namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Core.Enums.Word;

    public interface IWordRepository : IRepositoryBase<WordEntity>
    {
        Task<WordEntity> GetWordsAsync(
            LanguageType languageType,
            CategoryType categoryType);
    }
}

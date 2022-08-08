namespace WordSearch.Data.Repositories.Word
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Contexts.ApplicationDb;
    using WordSearch.Core.Enums.Word;

    public class WordRepository : RepositoryBase<WordEntity>, IWordRepository
    {
        public WordRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<WordEntity> GetWordsAsync(
            LanguageType languageType,
            CategoryType categoryType)
        {
            try
            {
                string language = languageType.ToString().ToLower();
                string category = categoryType.ToString().ToLower();

                var result = await QueryAsync(
                    word => word.Language == language,
                    word => word.Category == category);

                WordEntity words = result.FirstOrDefault();

                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<WordEntity>(ex.InnerException);
            }
        }
    }
}

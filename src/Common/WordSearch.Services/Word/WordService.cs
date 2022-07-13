namespace WordSearch.Services.Word
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class WordService : IWordService
    {
        private readonly IWordQueryFactory _wordFactory;

        private readonly IWordRepository _wordRepository;

        public WordService(
            IWordQueryFactory wordFactory,
            IWordRepository wordRepository)
        {
            _wordFactory = wordFactory;
            _wordRepository = wordRepository;
        }

        public async Task<List<string>> GetWords(
            LanguageType languageType,
            CategoryType categoryType)
        {
            try
            {
                var languageQuery = _wordFactory
                    .CreateLanguageQuery(languageType);

                var categoryQuery = _wordFactory
                    .CreateCategoryQuery(categoryType);

                var result = await _wordRepository.QueryAsync(
                    languageQuery,
                    categoryQuery);

                var words = ConvertToStringList(result);

                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<string>>(
                    ex.InnerException);
            }
        }

        private List<string> ConvertToStringList(List<WordEntity> words)
        {
            var stringList = new List<string>();

            words.ForEach(word => stringList.Add(word.Value));

            return stringList;
        }
    }
}

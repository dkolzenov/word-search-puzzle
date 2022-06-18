namespace WordSearch.Services.Word
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Word;

    public class WordService : IWordService
    {
        private readonly IWordQueryFactory _wordFactory;

        private readonly IWordRepository _wordRepository;

        public WordService(IWordQueryFactory wordFactory, IWordRepository wordRepository)
        {
            _wordFactory = wordFactory;
            _wordRepository = wordRepository;
        }

        public async Task<List<string>> GetWords(LanguageType languageType, CategoryType categoryType)
        {
            var languageQuery = _wordFactory.CreateLanguageQuery(languageType);
            var categoryQuery = _wordFactory.CreateCategoryQuery(categoryType);

            var result = await _wordRepository.QueryWords(languageQuery, categoryQuery);

            var words = ConvertToStringList(result);

            return words;
        }

        private List<string> ConvertToStringList(List<WordModel> wordList)
        {
            var stringList = new List<string>();

            wordList.ForEach(word => stringList.Add(word.Value));

            return stringList;
        }
    }
}

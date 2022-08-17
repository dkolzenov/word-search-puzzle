namespace WordSearch.Services.Word
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Word;
    using WordSearch.Core.Enums.Word;

    public class WordService : IWordService
    {
        private readonly IMapper _mapper;

        private readonly IWordRepository _wordRepository;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public WordService(
            IMapper mapper,
            IWordRepository wordRepository,
            IRandomChooserHelper randomChooserHelper)
        {
            _mapper = mapper;
            _wordRepository = wordRepository;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<List<WordModel>> GetWordsAsync(
            LanguageType languageType,
            CategoryType categoryType,
            int maxLength = int.MaxValue)
        {
            try
            {
                var result = await _wordRepository
                    .GetWordsAsync(languageType, categoryType);

                var words = _mapper
                    .Map<IEnumerable<WordModel>>(result)
                    .Where(word => word.Value.Length <= maxLength)
                    .ToList();

                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(
                    ex.InnerException);
            }
        }

        public async Task<List<WordModel>> GetRandomWordsAsync(
            LanguageType languageType,
            CategoryType categoryType,
            int count,
            int maxLength = int.MaxValue)
        {
            try
            {
                var words = await GetWordsAsync(
                    languageType,
                    categoryType,
                    maxLength);

                var randomWords = _randomChooserHelper
                    .GetRandomUniqueList(words, count);

                return randomWords;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(
                    ex.InnerException);
            }
        }
    }
}
